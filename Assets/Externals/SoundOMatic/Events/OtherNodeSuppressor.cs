using UnityEngine;
using System.Collections;

[AddComponentMenu("Suppressors/Other Node")]
public class OtherNodeSuppressor : Suppressor {
	public AudioNode triggeringNode;

	public void OnEnable(){
		if (triggeringNode!=null){
			triggeringNode.playStateChanged += onOtherNodeStarted;
		} else {
			this.enabled = false;
			Debug.Log ("OtherNodeSuppressor '"+this+"' without any other node to be suppressed by will be disabled", this);
		}
	}
	
	public void OnDisable(){
		if (triggeringNode!=null){
			triggeringNode.playStateChanged -= onOtherNodeStarted;
		}
	}
	
	public void onOtherNodeStarted(){
		suppress(triggeringNode.play);
	}	
}