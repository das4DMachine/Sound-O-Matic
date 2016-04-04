using UnityEngine;
using System.Collections;

[AddComponentMenu("Starters/Always")]
public class AlwaysStarter : Starter {
	public void OnEnable(){
		trigger();
	}
}
