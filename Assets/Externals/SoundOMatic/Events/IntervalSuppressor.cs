using UnityEngine;
using System.Collections;

[AddComponentMenu("Suppressors/Interval")]
public class IntervalSuppressor : Suppressor {
	public float interval = 60; // Interval in seconds
	public float duration = 10; // Number of seconds the suppressor is activate when it starts
	private long lastChangeTimestamp; // When the suppressor last stopped being activate or when it last started being active, depending on state
	private bool isActivated = false;
	
	public void OnEnable(){
		// Scramble starting point as if the system had been running already for some time
		lastChangeTimestamp = System.DateTime.Now.Ticks - (long)(random.NextDouble()*interval*TICKS_PER_SECOND);
	}
	
	public override void Update(){
		long time = System.DateTime.Now.Ticks;
		if (!isActivated){
			if (time > lastChangeTimestamp + (long)(interval*TICKS_PER_SECOND)){
				suppress(true);
				isActivated = true;
				lastChangeTimestamp = time;
			}
		} else {
			if (time > lastChangeTimestamp + (long)(duration*TICKS_PER_SECOND)){
				suppress(false);
				isActivated = false;
				lastChangeTimestamp = time;
			}
		}
		
		base.Update();
	}		
}