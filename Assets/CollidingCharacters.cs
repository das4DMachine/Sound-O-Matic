using UnityEngine;
using System.Collections;

public class CollidingCharacters : MonoBehaviour {

	public GameObject collidingSoundPrefab;
	public bool playOnAwake;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		collidingSoundPrefab = Resources.Load("CollisionSound") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log (gameObject.name + " was triggered by " + collider.gameObject.name);
		Instantiate(collidingSoundPrefab, transform.position, transform.rotation);
		audio.Play();
		}
}
