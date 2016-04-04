using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("Suppressors/Randomly")]
public class RandomSuppressor : Suppressor {
	public int triggers = 1; // Number of times to trigger per interval
	public int interval = 60; // Timespan in seconds. The suppressor will start #triggers times in #interval seconds
	public double minDuration = 10.0; // How long to at the very least suppress the sound
	public double maxDuration = 12.0; // How long to suppress at most
	
	private List<long> triggerTimestamps;  // Ordered list of timestamps to trigger on in this interval
	private long nextTriggerTimestamp;
	private long lastIntervalCalculation; // When the list was last filled
	private long thisDurationEnd; // When to stop suppressing
		
	public void OnEnable(){
		triggerTimestamps = new List<long>();
		lastIntervalCalculation = -1;
		nextTriggerTimestamp = System.Int64.MaxValue;
	}
	
	public override void Update(){
		long time = System.DateTime.Now.Ticks;
		if (time > lastIntervalCalculation + (long)(interval*TICKS_PER_SECOND)){
			recalculateInterval();
		}
		if (time > nextTriggerTimestamp){		
			suppress(true);
			double durationDuration = maxDuration - minDuration;
			thisDurationEnd = (long)(random.NextDouble()*durationDuration*TICKS_PER_SECOND) + time + (long)(minDuration*TICKS_PER_SECOND);
			fetchNextTrigger();
		} else if (time > thisDurationEnd){
			suppress(false);
			thisDurationEnd = System.Int64.MaxValue;
		}
		base.Update();
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
