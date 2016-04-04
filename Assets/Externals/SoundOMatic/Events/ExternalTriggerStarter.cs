using UnityEngine;
using System.Collections;

[AddComponentMenu("Starters/External Trigger")]
public class ExternalTriggerStarter : Starter, OSCListener {
	private static string NAMESPACE = "/dk/cavi/eventbus/core/events/TriggerEvent/";
	public string triggerName = "unnamedEvent0";
	private bool externalTriggerHasAppeared;
	public OSCPort oscPort;
	
	public void OnEnable(){	
		externalTriggerHasAppeared = false;
		if (oscPort == null){
			OSCPort port = (OSCPort) Object.FindObjectOfType(typeof(OSCPort));
			if (port==null){
				Debug.Log("Warning: no OSC input port found automatically, not able to trigger any starts!");
			} else {
				oscPort = port;
				if (oscPort.shouldWarnIfAutodetected()){
					Debug.Log("External trigger missing OSC input port, searching for anything - Found OSC port on port "+oscPort.getPort());
				}
			}
		}
		updateListenerRegistration();
	}
	
	public void OnDisable(){
		if (oscPort!=null){
			oscPort.removeListener(this);
		}
	}
	
	public void updateListenerRegistration(){
		if (oscPort!=null){
			oscPort.removeListener(this);
			oscPort.addListener(NAMESPACE, this);
		}
	}

	public override void Update(){
		base.Update();
		
		if (externalTriggerHasAppeared){
			externalTriggerHasAppeared = false;
			trigger();
		}
	}
	
	public void onOSCMessage(string address, ArrayList arguments){
		if (address.Equals(NAMESPACE + triggerName)){
			externalTriggerHasAppeared = true;
		}
	}
	
}
