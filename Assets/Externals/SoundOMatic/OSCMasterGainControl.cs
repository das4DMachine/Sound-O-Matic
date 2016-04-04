using UnityEngine;
using System.Collections;

[RequireComponent (typeof (SoundOMaticClient))]
public class OSCMasterGainControl : MonoBehaviour, OSCListener {
	private static string NAMESPACE = "/dk/cavi/guardiam/";
	public string triggerName = "gainControl";
	public float zeroValue = 0.5f;
	public float oneValue = 1f;
	public OSCPort oscPort;
	private SoundOMaticClient client;

	public void OnEnable(){
        client = this.GetComponent<SoundOMaticClient>();

        if (oscPort == null)
        {
			OSCPort port = (OSCPort) Object.FindObjectOfType(typeof(OSCPort));
			if (port==null){
				Debug.Log("Warning: no OSC input port found automatically, not able to control anything!", this);
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
	
	public void onOSCMessage(string address, ArrayList arguments){
		try {
			if (address.Equals(NAMESPACE + triggerName)){
				if (arguments.Count == 1 && arguments[0] is double){
					float input = Mathf.Max(0, Mathf.Min(1f, (float)((double) arguments[0])));
					client.masterGain = (oneValue-zeroValue)*input + zeroValue;
				}
			}
		} catch (System.Exception ex){
			Debug.Log(ex);
		}
	}
}
