using UnityEngine;
using System.Collections;

[AddComponentMenu("Suppressors/External Trigger")]
public class ExternalTriggerSuppressor : Suppressor, OSCListener {
	private static string NAMESPACE = "/dk/cavi/eventbus/core/events/TriggerEvent/";
	public string triggerName = "unnamedEvent0";
	public OSCPort oscPort;
	
	public void OnEnable(){	
		if (oscPort == null){
			OSCPort port = (OSCPort) Object.FindObjectOfType(typeof(OSCPort));
			if (port==null){
				Debug.Log("Warning: no OSC input port found automatically, not able to suppress anything!");
			} else {
				oscPort = port;
				if (oscPort.shouldWarnIfAutodetected()){
					Debug.Log("External trigger suppressor missing OSC input port, searching for anything - Found OSC port on port "+oscPort.getPort());
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
	}
	
	public void onOSCMessage(string address, ArrayList arguments){
		if (address.Equals(NAMESPACE + triggerName)){
			if (arguments!=null && arguments.Count > 0){
				if (arguments[0].Equals("APPEARED")){
					Debug.Log("Ap");
					suppress(true);
				} else if (arguments[0].Equals("DISAPPEARED")){
					Debug.Log("Dis");
					suppress(false);
				}
			} else {
				Debug.Log("Invalid trigger argument length or null arguments for "+NAMESPACE+triggerName);
			}
		}
	}
	
}
