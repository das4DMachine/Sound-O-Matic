// ------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StreamAudioNode : AudioNode {
	[HideInInspector]
	public string _streamURL;
	public string streamURL {
		get { return _streamURL; }
		set {
			if (value!=_streamURL){
				_streamURL = value;
				resetStateTrackers();
			}
		}
	}

	public override string getNodeTypeString(){
		return "stream "+streamURL; // URL as id
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
