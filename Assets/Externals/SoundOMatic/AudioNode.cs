using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class AudioNode : SoundOMaticNode {
	protected static long TICKS_PER_SECOND = 10000000;
	
	public static int FALLOFF_CURVE_STEPS = 32;
	
	[HideInInspector]
	public string audioName = "n/a";

	[HideInInspector]
	public int _audioIdentifier = 0; // backing field	
	public int audioIdentifier {
		get { return _audioIdentifier; }
		set {
			if (value!=_audioIdentifier){
				_audioIdentifier = value;
				audioIdentifierChanged = true;
				resetStateTrackers();
			}
		}
    }

    [HideInInspector]
	public bool _play = false;
	public bool play {
		get { return _play; }
		set {
			if (value!=_play){
				_play = value;
				if (playStateChanged!=null){
                    playStateChanged();
                    setupFader();
				}
			}
		}
	}
	
	public float rangeStart = 0f;
	public float rangeStop = 1f;


	[HideInInspector]
	public bool loop;
	[HideInInspector]
	public float silence;

	// Fading
	[Tooltip("0 gain |  3x gain")]
	[Range(0.0f, 3.0f)]
	public float gain = 1f;
	public bool startFadedIn = true;
	private float fader = 1f;
	private float fadeTarget = 1f;
	private AnimationCurve fadeCurve = AnimationCurve.EaseInOut(0,1,1,1);
	private long fadeStartTimestamp = System.DateTime.Now.Ticks;
	private long fadeTargetTimestamp = System.DateTime.Now.Ticks;
	private bool currentlyFading = false;

    [HideInInspector]
    public AnimationCurve fallOffCurve = AnimationCurve.EaseInOut(0, 1, 1, 0);

	private float[] fallOffCurveSamples = new float[FALLOFF_CURVE_STEPS];
	
	// State trackers
	private bool fallOffCurveChanged = true;
	private bool audioIdentifierChanged = true;
	private string oldFilterNames = "-1";
	private int nonPlayingFrames = 0; // How many frames this node has not been playing
	
	// Sound suppression
	private float calculatedGainSuppressionFactor = 1f;
	private bool shouldRecalculateGainSuppressionFactor = false;	
	private bool startOnNextUpdate = false;
	private bool rewindOnNextUpdate = false;	
	
	// Events and delegates
	public delegate void StateChanged();
	public event StateChanged playStateChanged;	

	public void Start() {
        setupFader();
	}

    private void setupFader()
    {
        if (Application.isPlaying)
        {
            if (!startFadedIn)
            {
                fader = 0f;
            }
            else
            {
                fader = 1f;
            }
        }
        else
        {
            fader = 1f;
        }
    }

	public virtual string getNodeTypeString(){
		// Default node type is 
		return "soundbase";
	}

	public override void sendUpdate(SoundOMaticClient client){
		if (!enabled) return;
		if (shouldRecalculateGainSuppressionFactor){
			// Find the suppressor that suppresses the most right now (smallest gain factor)
			Suppressor[] suppressors = GetComponents<Suppressor>();		
			calculatedGainSuppressionFactor = 1f;
			foreach (Suppressor suppressor in suppressors){
				calculatedGainSuppressionFactor = System.Math.Min(calculatedGainSuppressionFactor, suppressor.getGainSuppressionFactor());
			}
			calculatedGainSuppressionFactor = System.Math.Max(0, calculatedGainSuppressionFactor);
			shouldRecalculateGainSuppressionFactor = false;
		}

		// Handle queued rewinds and restarts
		bool firstPlay = false;
		if (rewindOnNextUpdate){
			rewindOnNextUpdate = false;
			startOnNextUpdate = true;
			play = false;			
		} else if (startOnNextUpdate){ // Intentionally left as elseif, to allow stop+start in successive updates
			play = false; // to trigger any listener nodes
			play = true;
			startOnNextUpdate = false;
			firstPlay = true;
		}

		// Optimization: Avoid sending anything if the node is not playing and hasn't been playing for a frame
		if (play == true){
			nonPlayingFrames = 0;
		} else {
			nonPlayingFrames++;
		}
		if (nonPlayingFrames > 2){
			return;
		}

		// Actually send the node data
		client.sendPacket("select AudioNode "+getUniqueName(client));
		if (audioIdentifierChanged) client.sendPacket("audioIdentifier "+getNodeTypeString()+" "+audioIdentifier); 
		base.sendUpdate(client);
		client.sendPacket("position ("+transform.position.x+", "+transform.position.y+", "+transform.position.z+")");
		client.sendPacket("gain "+(gain*calculatedGainSuppressionFactor*fader));
		client.sendPacket("innerFallOffDistance "+rangeStart);
		client.sendPacket("outerFallOffDistance "+rangeStop);
        if (fallOffCurveChanged) client.sendPacket("fallOffCurve {" + string.Join(", ", System.Array.ConvertAll<float, string>(fallOffCurveSamples, System.Convert.ToString)) + "}");
		if (getNodeTypeString()=="soundbase"){
			client.sendPacket("silence " + silence);
			client.sendPacket("loop "+loop);
		}
		client.sendPacket("play "+play +" "+firstPlay);
		
		// Update filters
		VSTFilter[] filters = GetComponents<VSTFilter>();		
		int filterIndex = 0;
		string filterNames = "";
		bool first = true;
		foreach (VSTFilter filter in filters){
			if (first){
				first = false;
			} else {
				filterNames += ", ";
			}
			filterNames += getUniqueName(client)+"."+filter.getUniqueName(client);
		}		
		bool filtersChanged = !filterNames.Equals(oldFilterNames);
		if (filtersChanged) {
			client.sendPacket("filters {"+filterNames+"}");
		}
		foreach (VSTFilter filter in filters){
			//if (filtersChanged) filter.resetStateTrackers();
			if (filter.hasUpdate()){
				client.sendPacket("select AudioFilter "+getUniqueName(client)+"."+filter.getUniqueName(client));
				filter.sendUpdate(client);
			}
			filterIndex ++;
		}
		oldFilterNames = filterNames;
		
		
		fallOffCurveChanged = false;
		audioIdentifierChanged = false;
	}

#if UNITY_EDITOR	
	void OnDrawGizmosSelected() {
		Gizmos.color = new Color(0, 1, 0, 0.6F);
		Gizmos.DrawWireSphere(transform.position, rangeStop);
		Gizmos.color = new Color(1, 0, 0, 0.6F);
		Gizmos.DrawWireSphere(transform.position, rangeStart);
	}
	
    void OnDrawGizmos() {
		Gizmos.color = new Color(1, 1, 1, 0.5F);
		Gizmos.DrawLine(transform.position, new Vector3(transform.position.x,0,transform.position.z));
		if (play){
			Gizmos.color = new Color(0, 1, 0, 0.2F);
			Gizmos.DrawWireSphere(transform.position, rangeStop);
			Gizmos.DrawIcon(transform.position, "speaker.png", true);
		} else {
			Gizmos.DrawIcon(transform.position, "speaker_muted.png", true);
		}
    }
#endif
	
	public void OnEnable(){
		resetStateTrackers();
	}
	
	public void OnDisable(){
		// If an AudioNode node disconnects kill it on the server too
		SoundOMaticClient ourRootNode = GetComponentInParent<SoundOMaticClient>();
		if (ourRootNode!=null){
			ourRootNode.sendPacket("select AudioNode "+getUniqueName(ourRootNode));
			ourRootNode.sendPacket("delete");
		}
		
		fader = 1f;
	}
	
	public override void resetStateTrackers(){
		base.resetStateTrackers();
		audioIdentifierChanged = true;
		oldFilterNames = "-1";
        updateFallOffCurve();
		nonPlayingFrames = 0;
		foreach (VSTFilter filter in GetComponents<VSTFilter>()){
			filter.resetStateTrackers();
		}
	}
	
    public void updateFallOffCurve()
    {
        if (fallOffCurveSamples.Length != FALLOFF_CURVE_STEPS) fallOffCurveSamples = new float[FALLOFF_CURVE_STEPS];
        for (int i = 0; i < FALLOFF_CURVE_STEPS; i++)
        {
            float xValue = i / (float)FALLOFF_CURVE_STEPS;
            float yValue = fallOffCurve.Evaluate(xValue);
            fallOffCurveSamples[i] = yValue;
        }
        fallOffCurveChanged = true;
    }

	public void recalculateGainSuppressionFactor(){
		shouldRecalculateGainSuppressionFactor = true;
	}
	
	public void startOnUpdate(){
		startOnNextUpdate = true;
	}
	public void rewindOnUpdate(){
		rewindOnNextUpdate = true;
	}
	
	public void fadeOut(int seconds) {
		if(fadeTarget == 0f && currentlyFading) {
			//Already fading out, ignore
			return;
		}
		
		if(fader == 0f) {
			//Already at fadeTarget, ignore
			return;
		}
		
		fadeTarget = 0f;
		fadeCurve = AnimationCurve.EaseInOut(0, fader, 1, fadeTarget);
		
		fadeStartTimestamp = System.DateTime.Now.Ticks;
		fadeTargetTimestamp = fadeStartTimestamp + seconds * TICKS_PER_SECOND;
		currentlyFading = true;
	}

	public void fadeIn(int seconds) {
		if(fadeTarget == 1f && currentlyFading) {
			//Already fading in, ignore
			return;
		}
		
		if(fader == 1f) {
			//Already at fadeTarget, ignore
			return;
		}

		fadeTarget = 1f;
		fadeCurve = AnimationCurve.EaseInOut(0, fader, 1, fadeTarget);
		
		fadeStartTimestamp = System.DateTime.Now.Ticks;
		fadeTargetTimestamp = fadeStartTimestamp + seconds * TICKS_PER_SECOND;
		currentlyFading = true;
	}

    public void startPlaying() {
		startOnUpdate();
    }

    public void stopPlaying() {
        play = false;
    }

    public void log(string msg)
    {
        Debug.Log("AudioNode.log: ["+msg+"]");
    }

    public void Update() {
		if(currentlyFading) {
			long currentTicks = System.DateTime.Now.Ticks;
			if(currentTicks > fadeTargetTimestamp) {
				fader = (float)fadeTarget;
				currentlyFading = false;
			} else {
				long fadeTotalDuration = fadeTargetTimestamp - fadeStartTimestamp;

				double fadeFactor = 1.0 - (fadeTargetTimestamp - currentTicks) / (double)fadeTotalDuration;
				
				fader = fadeCurve.Evaluate((float) fadeFactor);
			}
		}
	}
}
