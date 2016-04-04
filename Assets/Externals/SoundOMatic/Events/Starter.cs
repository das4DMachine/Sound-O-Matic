using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Starter : MonoBehaviour {
	[Tooltip("Only start if it has not been started already")]
	public bool rewindIfPlaying;
	
	[Tooltip("The probability that this starter will actually start when it triggers. 1 means it always starts and 0 means never")]
	[Range(0.0f, 1.0f)]
	public float startProbability = 1;

    [HideInInspector]
    public string choosenAnimation = "";

    [HideInInspector]
    public List<string> animationNames = null;

    protected static System.Random random = new System.Random((int)System.DateTime.Now.Ticks);	
	protected static long TICKS_PER_SECOND = 10000000;
	
	// Subclasses decide when to call this function
	public void trigger(){
		Starter.trigger(this.gameObject, rewindIfPlaying, startProbability, choosenAnimation);
	}

	public static void trigger(GameObject target, bool rewindIfPlaying){

        string foundAnimation = null;

        if (target.GetComponent<Animation>() != null)
        {
            if (target.GetComponent<Animation>().clip != null)
            {
                foundAnimation = target.GetComponent<Animation>().clip.name;
            }
        }

        Starter.trigger(target, rewindIfPlaying, 1f, foundAnimation);
	}

	public static void trigger(GameObject target, bool rewindIfPlaying, float startProbability, string choosenAnimation){
		if (target==null){
			Debug.Log("Attempted to start null object, ignoring");
			return;
		}

		// Check if triggering is currently suppressed by an attached suppressor
		Suppressor[] suppressors = target.GetComponents<Suppressor>();
		foreach (Suppressor suppressor in suppressors){
			if (suppressor.isBlockingStart()) return; // We were blocked. Too bad - now nothing happens
		}
		
		// Check if randomness is suppressing us
		if (startProbability < 1 && random.NextDouble() > startProbability){
			return; // Blocked by randomness - nothing happens
		}
	
        if (choosenAnimation == null || choosenAnimation.Equals(""))
        {
            //No animation selected, operate on the audio node instead
            AudioNode audioNode = target.GetComponent<AudioNode>();
            if (audioNode == null)
            {
                Debug.Log("Missing an animation or AudioNode for triggering starter script on " + target);
                return;
            }
            if (audioNode.play && rewindIfPlaying) {
                audioNode.rewindOnUpdate();
                audioNode.startOnUpdate();
            } else {
                audioNode.startPlaying();
            }
        } else {
            //Reset layers?
            int layer = 0;
            foreach (AnimationState state in target.GetComponent<Animation>())
            {
                state.layer = layer;
                layer++;
            }

            if (choosenAnimation.Equals("Default"))
            {
                choosenAnimation = target.GetComponent<Animation>().clip.name;
            }

            if (target.GetComponent<Animation>()[choosenAnimation] == null)
            {
                Debug.Log(target + " does not contain an animation named [" + choosenAnimation + "]", target);
                return;
            }

            //Play animation
            if (target.GetComponent<Animation>().IsPlaying(choosenAnimation) && rewindIfPlaying)
            {
                target.GetComponent<Animation>().Stop(choosenAnimation);
                target.GetComponent<Animation>().PlayQueued(choosenAnimation, QueueMode.PlayNow);
            }
            else if (!target.GetComponent<Animation>().IsPlaying(choosenAnimation))
            {
                target.GetComponent<Animation>().PlayQueued(choosenAnimation, QueueMode.PlayNow);
            }
        }
	}
	
	public virtual void Update(){
	}
}
