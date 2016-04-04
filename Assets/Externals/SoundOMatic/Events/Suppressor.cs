using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioNode))]
public abstract class Suppressor : MonoBehaviour {
	protected static System.Random random = new System.Random((int)System.DateTime.Now.Ticks);	
	protected static long TICKS_PER_SECOND = 10000000;


	public bool affectStart = true; // Whether to block starting of new sounds
	public bool affectVolume = true; // Whether to suppress sound volume	
	
	[Range(0,60.0f)]
	public float fadeIn = 10f; // How long it takes for the suppressor to kick in
	[Range(0,60.0f)]
	public float fadeOut = 10f; // How long it takes to stop suppressing
	[Range(0,1.0f)]
	public float suppressionLevel = 0.5f; // How much to suppress the volume when suppressing
	public bool negateEffect = false; // The suppressor acts like its logic is reversed, suppressing and blocking when not active
	
	// State machine variables
	private bool isSuppressing = false;
	private long fadeTargetTimestamp = -1;
	private long fadeOriginTimestamp = -1;
	private float fadeOrigin = 1;
	private float fadeTarget = 1;
	private bool isFading = true;
	private float currentSuppressionLevel = 1;
	
	public bool isBlockingStart(){
		return (isSuppressing && affectStart) || (negateEffect && affectStart && !isSuppressing);
	}
	
	public float getGainSuppressionFactor(){
		if (affectVolume){
			return currentSuppressionLevel;
		} else {
			return 1;
		} 
	}
	
	public virtual void Update(){
		if (affectVolume && isFading){
			currentSuppressionLevel = calculateTimedFade(fadeOriginTimestamp, fadeTargetTimestamp, fadeOrigin, fadeTarget);
			if (System.DateTime.Now.Ticks > fadeTargetTimestamp){
				isFading = false;
			}

			// Inform AudioNode to recalculate gain
			AudioNode node = GetComponent<AudioNode>();
			node.recalculateGainSuppressionFactor();
		}
	}
	
	protected void suppress(bool shouldSuppress){
		isSuppressing = shouldSuppress;
		
		// Fading
		fadeOrigin = calculateTimedFade(fadeOriginTimestamp, fadeTargetTimestamp, fadeOrigin, fadeTarget);
		if (shouldSuppress && !negateEffect){
			fadeTarget = suppressionLevel;
		} else if (shouldSuppress && negateEffect){
			fadeTarget = 1;
		} else if ((!shouldSuppress) && !negateEffect){
			fadeTarget = 1;
		} else {
			fadeTarget = suppressionLevel;
		}
		fadeTargetTimestamp = (long)((shouldSuppress?fadeIn:fadeOut)*TICKS_PER_SECOND) + System.DateTime.Now.Ticks;
		fadeOriginTimestamp = System.DateTime.Now.Ticks;
		isFading = true;
	}
	
	private float calculateTimedFade(long startTime, long endTime, float startValue, float endValue){
		double duration = endTime - startTime;
		double progress = System.DateTime.Now.Ticks - startTime;
		float diff = endValue - startValue;		
		float currentValue;
		if (duration <= 0) {
			currentValue = endValue;
		} else {
			currentValue = (float) ( ((progress / duration) * diff) + startValue);
		}
		
		if (startValue>endValue){
			return System.Math.Min(startValue, System.Math.Max(endValue, currentValue));
		} else {
			return System.Math.Min(endValue, System.Math.Max(startValue, currentValue));
		}
	}
	
}
