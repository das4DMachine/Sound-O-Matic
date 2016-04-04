using UnityEngine;
using System.Collections;
using System.Linq;


public abstract class SoundOMaticNode : Identifiable {
	[HideInInspector]
	public int[] layers = new int[] {0};
	
	// State trackers
	protected bool layersChanged = true;
	
	public virtual void sendUpdate(SoundOMaticClient client){
		if (layersChanged) client.sendPacket("layers {"+string.Join(", ", System.Array.ConvertAll<int,string>(layers,System.Convert.ToString))+"}");		
		layersChanged = false;	
	}

	public int[] getLayers(){
		return layers;
	}
	
	public bool sharesLayer(SoundOMaticNode otherNode){
		return layers.Intersect(otherNode.layers).Count()>0;
	}
	
	public void setLayers(int[] newLayers){
		layers = newLayers;
		layersChanged = true;
	}	

	public virtual void resetStateTrackers(){
		layersChanged = true;
	}	
}
