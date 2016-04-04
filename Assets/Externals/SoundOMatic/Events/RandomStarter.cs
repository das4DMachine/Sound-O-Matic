using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("Starters/Randomly")]
public class RandomStarter : Starter {
	public int triggers = 1; // Number of times to trigger
	public int interval = 60; // Timespan in seconds. The starter will start #triggers times in #interval seconds if not blocked
	public int duration = 3; // Seconds to wait after triggering before continuing time calculations

	private List<long> triggerTimestamps;  // Ordered list of timestamps to trigger on in this interval
	private long nextTriggerTimestamp;
	private long lastIntervalCalculation; // When the list was last filled
		
	public void OnEnable(){
		triggerTimestamps = new List<long>();
		lastIntervalCalculation = -1;
		nextTriggerTimestamp = System.Int64.MaxValue;
	}
	
	public override void Update(){
		base.Update();
		long time = System.DateTime.Now.Ticks;
		if (time > lastIntervalCalculation + (long)(interval*TICKS_PER_SECOND)){
            recalculateInterval();
		}
		if (time > nextTriggerTimestamp){
			trigger();
            
            delayTimestamps(duration);

            fetchNextTrigger();
        }
	}

	/**
	 * Moves all future timestamps forward #delay secs
	 */
	private void delayTimestamps(int delay){
		lastIntervalCalculation += delay*TICKS_PER_SECOND;
		for (int i = 0; i < triggerTimestamps.Count; i++){
			triggerTimestamps[i] += delay*TICKS_PER_SECOND;
		}
	}
	
	private void fetchNextTrigger(){
		if (triggerTimestamps.Count > 0){
			nextTriggerTimestamp = triggerTimestamps[0];
			triggerTimestamps.RemoveAt(0);
		} else {
			// Out of triggers for this time interval
			nextTriggerTimestamp = System.Int64.MaxValue;
		}
	}
	
	private void recalculateInterval(){
		long time = System.DateTime.Now.Ticks;
		for (int i = 0; i < triggers; i ++){
			triggerTimestamps.Add((long)(random.NextDouble()*interval*TICKS_PER_SECOND + time));
		}
		triggerTimestamps.Sort();
		fetchNextTrigger();
		lastIntervalCalculation = time;
	}
}
