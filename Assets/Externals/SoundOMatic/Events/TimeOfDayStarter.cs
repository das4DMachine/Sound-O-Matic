using UnityEngine;
using System.Collections;

/**
	This whole starter idea is revolving around the idea that we wont be using it past midnight,
	so 23:59 is the "latest" time possible, and 00:00 is the earliest time possible.
**/

[AddComponentMenu("Starters/TimeOfDay")]
public class TimeOfDayStarter : Starter {
	
	[Range(0,23)]
	public int hour;
	
	[Range(0,59)]
	public int minutes;

	private bool isEnabledAfterTime;
	private bool hasRun;
	
	public void OnEnable(){
		hasRun = false;
		isEnabledAfterTime = isPastTime();
	}
	
	public override void Update(){
		base.Update();
		if (!hasRun && !isEnabledAfterTime && isPastTime()){
			trigger();
			hasRun = true;
		}
	}	
	
	public bool isPastTime() {
		System.DateTime date = System.DateTime.Now;
		
		if(date.Hour == hour) {
			//We are on the hour, check if minutes are past
			return date.Minute >= minutes;
		} else {
			return date.Hour > hour;
		}
	}	
	
}
