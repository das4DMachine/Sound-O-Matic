using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(AudioNode), true)]
public class AudioNodeEditor : Editor {		
	// Target target = target! - hidden field
	public Rect searchWindowRect = new Rect(20, 20, 120, 50);
	
    public override void OnInspectorGUI() {
		AudioNode ourTarget = (AudioNode) target;

		if (ourTarget.getNodeTypeString()=="soundbase"){
			if(GUILayout.Button("Search SoundBase")){
				SoundBaseSearchWindow.createWindow(ourTarget);
			}
			EditorGUILayout.HelpBox(ourTarget.audioName, MessageType.Info);
		}
		
		bool oldPlay = ourTarget.play;
		ourTarget.play = EditorGUILayout.Toggle("Play", ourTarget.play);

		int oldIdentifier = ourTarget.audioIdentifier;
		bool oldLoop = ourTarget.loop;
		float oldSilence = ourTarget.silence;

		// Show the identifier as different things depending on node type
		int identifier = -1;
        if (ourTarget.GetType() == typeof(AudioNode))
        {
            identifier = EditorGUILayout.IntField("Audio ID", ourTarget.audioIdentifier);
            ourTarget.loop = EditorGUILayout.Toggle("Looping", ourTarget.loop);
            ourTarget.silence = EditorGUILayout.FloatField("Extra Silence", ourTarget.silence);
        }
        if (ourTarget.GetType() == typeof(LiveAudioNode))
        {
            identifier = EditorGUILayout.IntField("Channel", ourTarget.audioIdentifier);
        }
        if (ourTarget.GetType() == typeof(StreamAudioNode))
        {
            ((StreamAudioNode)ourTarget).streamURL = EditorGUILayout.TextField("Stream URL", ((StreamAudioNode)ourTarget).streamURL);
        }
        if (ourTarget.GetType() == typeof(SineWaveAudioNode))
        {
            identifier = EditorGUILayout.IntSlider("Frequency", ourTarget.audioIdentifier, 10, 3000);
		}
		ourTarget.audioIdentifier = identifier;
        DrawDefaultInspector();

		// Layers
		SoundOMaticClient hyperNode = (SoundOMaticClient) SoundOMaticClient.findCloseComponent<SoundOMaticClient>(ourTarget.gameObject);						
		int mask = 0;
		foreach (int layer in ourTarget.getLayers()){
			mask |= 1<<layer;
		}
		int oldMask = mask;
		mask = EditorGUILayout.MaskField ("Layers", mask, hyperNode.layers);
		ArrayList foundLayers = new ArrayList();		
		for (int layer = 0; layer < hyperNode.layers.Length; layer++){
			if ((mask & 1<<layer) == (1<<layer)){
				foundLayers.Add(layer);
			}
		}		
		ourTarget.setLayers((int[]) foundLayers.ToArray(typeof(int)));
		
		//Recalculate mask, Unity does something funny when set to Everything
		mask = 0;
		foreach (int layer in ourTarget.getLayers()){
			mask |= 1<<layer;
		}

		if (ourTarget.getLayers().Length > 1){
			string msg = "Choosen layers: ";
			bool first = true;
			foreach(int layer in ourTarget.getLayers()) {
				if(first) {
					first = false;
				} else {
					msg += ", ";
				}
				msg += hyperNode.layers[layer];
			}
			EditorGUILayout.HelpBox(msg, MessageType.Info);
		} else if (ourTarget.getLayers().Length == 0){
			EditorGUILayout.HelpBox("This AudioNode does not have any active layers!", MessageType.Warning);
		}
		
		// Update Gain curve
        ourTarget.fallOffCurve = EditorGUILayout.CurveField("Falloff Curve", ourTarget.fallOffCurve, GUILayout.Height(80));
        ourTarget.updateFallOffCurve();

		if (oldMask != mask || oldPlay != ourTarget.play || oldIdentifier != ourTarget.audioIdentifier || oldLoop!= ourTarget.loop || oldSilence!= ourTarget.silence) {
			if (ourTarget.getNodeTypeString()=="soundbase"){
				if (oldIdentifier != ourTarget.audioIdentifier){
                	ourTarget.audioName = SoundBaseSearchWindow.getNameFromId(ourTarget.audioIdentifier);
            	}
			}
			EditorUtility.SetDirty(target);
		}
    }
	
	void OnSceneGUI () {
		AudioNode ourTarget = (AudioNode) target;	
	    ourTarget.rangeStop = Handles.RadiusHandle (Quaternion.identity, ourTarget.transform.position, ourTarget.rangeStop);
		if (ourTarget.rangeStop < ourTarget.rangeStart) ourTarget.rangeStart = ourTarget.rangeStop;
	    ourTarget.rangeStart = Handles.RadiusHandle (Quaternion.identity, ourTarget.transform.position, ourTarget.rangeStart);
		if (ourTarget.rangeStart > ourTarget.rangeStop) ourTarget.rangeStop = ourTarget.rangeStart;
		if (ourTarget.rangeStart < 0) ourTarget.rangeStart = 0;
		if (ourTarget.rangeStop < 0) ourTarget.rangeStop = 0;
		
        if (GUI.changed){
	            EditorUtility.SetDirty (target);
	    }	
	}	
}