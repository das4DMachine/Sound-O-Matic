using UnityEngine;
using System.Collections;

[AddComponentMenu("Starters/Interval")]
public class IntervalStarter : Starter {
	public float interval = 60; // Interval in seconds
	private long lastStart; // When the trigger was last fired
	
	public void OnEnable(){
		// Scramble starting point as if the system had been running already for some time
		lastStart = System.DateTime.Now.Ticks - (long)(random.NextDouble()*interval*TICKS_PER_SECOND);
	}
	
	public override void Update(){
		base.Update();
		long time = System.DateTime.Now.Ticks;
		if (time > lastStart + (long)(interval*TICKS_PER_SECOND)){
			trigger();
			lastStart = time;
		}
	}
}
