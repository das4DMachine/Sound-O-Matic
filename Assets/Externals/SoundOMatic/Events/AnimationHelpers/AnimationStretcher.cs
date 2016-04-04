using UnityEngine;
using System.Collections;

[AddComponentMenu("Animation Helpers/Stretcher")]
public class AnimationStretcher : MonoBehaviour {

	public float multiplier = 1.0f;

	public void Update () {
		foreach (AnimationState state in GetComponent<Animation>()) {
			state.speed = 1.0f / multiplier;
		}
	}
}
