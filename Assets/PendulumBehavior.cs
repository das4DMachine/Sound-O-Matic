using UnityEngine;
using System.Collections;
using System.Threading;

public class PendulumBehavior : MonoBehaviour {
    public float angle = 60.0f;
    public float speed = 1.5f;

    Quaternion qStart, qEnd;

    // Use this for initialization
    void Start () {
        qStart = Quaternion.AngleAxis(angle, Vector3.forward);
        qEnd = Quaternion.AngleAxis(-angle, Vector3.forward);
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Lerp(qStart, qEnd, (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f);
    }
}
