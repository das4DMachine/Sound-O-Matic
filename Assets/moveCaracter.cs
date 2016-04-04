using UnityEngine;
using System.Collections;

public class moveCaracter : MonoBehaviour {

    public float speed = 10;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 
            speed*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
