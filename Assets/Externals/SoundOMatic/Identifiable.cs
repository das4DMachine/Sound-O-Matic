using UnityEngine;
using System.Collections;

public abstract class Identifiable : MonoBehaviour {
	protected string uniqueName = null;

	public string getUniqueName(SoundOMaticClient client){
		if (uniqueName==null || uniqueName.Length==0) uniqueName = client.getUniqueName(this);
		return uniqueName;
	}
}
