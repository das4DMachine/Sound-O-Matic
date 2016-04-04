using UnityEngine;
using System.Collections;

public class ListenerNode : SoundOMaticNode {
	public int channel;
	
	public override void sendUpdate(SoundOMaticClient client){
		client.sendPacket("select ListenerNode "+getUniqueName(client));	
		client.sendPacket("channel "+channel);
		base.sendUpdate(client);
		client.sendPacket("position ("+transform.position.x+", "+transform.position.y+", "+transform.position.z+")");
	}
	
#if UNITY_EDITOR	
	void OnDrawGizmosSelected(){
		AudioNode[] nodes = FindObjectsOfType(typeof(AudioNode)) as AudioNode[];
		foreach (AudioNode node in nodes){
			float distance = Vector3.Distance(node.transform.position, transform.position);
			if (distance < node.rangeStop && distance > node.rangeStart){
				if (node.sharesLayer(this)){
					Gizmos.color = new Color(0, 1, 0, 0.6F);
				} else {
					Gizmos.color = new Color(1, 0, 0, 0.6F);
				}
				Gizmos.DrawLine(transform.position, node.transform.position);
			}
		}
	}
	
    void OnDrawGizmos() {
		Gizmos.color = new Color(1, 1, 1, 0.5F);
		Gizmos.DrawLine(transform.position, new Vector3(transform.position.x,0,transform.position.z));
		Gizmos.color = new Color(0, 0, 1, 0.5F);
		Gizmos.DrawIcon(transform.position, "microphone.png", true);
		UnityEditor.Handles.Label(transform.position, "ch"+channel);
    }	
#endif
	
	public void OnEnable(){
		resetStateTrackers();
	}	
	
	public override void resetStateTrackers(){
		base.resetStateTrackers();	
	}
}
