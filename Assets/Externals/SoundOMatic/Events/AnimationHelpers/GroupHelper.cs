using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[AddComponentMenu("Animation Helpers/Groups")]
public class GroupHelper : MonoBehaviour {
	public GameObject[] targets;
	public bool rewindIfPlaying = false;
	public bool activateDirectly = true;
	public bool activateChildren = false;
	public bool activateGrandchildren = false;
	private int currentNode = 0;	
	protected static System.Random random = new System.Random((int)System.DateTime.Now.Ticks);		
	
	/**
	 * Cannot be used to synchronously start groups of nodes that do not share
	 * a common direct parent as such nodes would not be in a sync group together.
	 * It can still start them "close enough" for most purposes.
	 */
	public void startAll(){
		GameObject[] realTargets = getRealTargets();
        foreach(GameObject node in realTargets)
        {
            Starter.trigger(node, rewindIfPlaying);
        }
	}
	
	/**
	 * Starts from 1 to #howMany of the group members, chosen completely at random from
	 * the list of targets
	 */
	public void startSome(int howMany){
		GameObject[] realTargets = getRealTargets();	
		for (int i = 0; i<howMany; i++){
			GameObject node = realTargets[(int)(random.NextDouble()*realTargets.Length)];
			Starter.trigger(node, rewindIfPlaying);
		}
	}
	
	/**
	 * Starts a few of the group members in the order given by the list of nodes.
	 * At the next call to this function it will continue from where it left.
	 */
	public void startNext(int howMany){
		GameObject[] realTargets = getRealTargets();
		for (int i = 0; i<howMany; i++){
			if (currentNode >= realTargets.Length){
				currentNode = 0;
			}
			Starter.trigger(realTargets[currentNode], rewindIfPlaying);
			currentNode++;
		}
	}
	
	/**
	 * Stops any animations or playback on any nodes in the group, regardless
	 * of whether they were started by this helper or not.
	 */
	public void stopAll(){
		foreach (GameObject node in getRealTargets()){
			AudioNode audioNode = node.GetComponent<AudioNode>();			
			if (audioNode==null){
				audioNode.play = false;
			}
			node.GetComponent<Animation>().Stop();
		}
	}

	public void runAnimation(string animationName){
		foreach (GameObject node in getRealTargets()){
			Starter.trigger(node, rewindIfPlaying, 1f, animationName);
		}
	}
	
	public GameObject[] getRealTargets(){	
		List<GameObject> realTargets = new List<GameObject>();
		
		if (targets!=null){
			if (activateDirectly){
				foreach (GameObject target in targets){
					if (isRealTarget(target)){
                        realTargets.Add(target);
					}
				}		
			}
			if (activateChildren || activateGrandchildren){
				foreach (GameObject target in targets){
					foreach (Transform childTransform in target.transform){
						if (activateChildren && isRealTarget(childTransform.gameObject)){
							realTargets.Add(childTransform.gameObject);
						}
						if (activateGrandchildren){
							foreach (Transform grandchildTransform in childTransform.gameObject.GetComponentsInChildren<Transform>()){
								if (grandchildTransform == childTransform) continue;
								if (isRealTarget(grandchildTransform.gameObject)){
									realTargets.Add(grandchildTransform.gameObject);
								}
							}
						}
					}
				}					
			}			
		}
		return realTargets.ToArray();
	}

    public void log(string msg)
    {
        Debug.Log("AudioNode.log: [" + msg + "]");
    }

	private bool isRealTarget(GameObject potentialTarget){
		if (potentialTarget==null) return false;
		return potentialTarget.GetComponent<Animation>() != null || (potentialTarget.GetComponent<AudioNode>() != null);
	}
}
