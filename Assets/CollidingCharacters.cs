using UnityEngine;
using System.Collections;

public class CollidingCharacters : MonoBehaviour {

	public GameObject collidingSoundPrefab;
	public GameObject spawnSound1;
	public Transform collidingSound1;
	public bool playOnAwake;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		spawnSound1 = GameObject.Find("Sphere");
		collidingSoundPrefab = Resources.Load("CollisionSound");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log (gameObject.name + " was triggered by " + collider.gameObject.name);
		collidingSound1 = Instantiate(collidingSoundPrefab, transform.position, transform.rotation);
		collidingSound1.transform.parent = spawnSound1.transform;
		}
}
