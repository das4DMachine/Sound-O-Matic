using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class LiveAudioNode : AudioNode {
	public override string getNodeTypeString(){
		// Default node type is 
		return "input";
	}

	// Use this for initialization
	public new void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public new void Update () {
		base.Update ();
	}
}
