using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    public AccellerometerInput input;
    public Rigidbody2D Shiprigidbody;
    public float moveForce = 5.0f;

	// Use this for initialization
	void Start () {
        if (!input)
            throw new System.Exception("No input added");
        if (!Shiprigidbody)
            throw new System.Exception("No rigidbody");
	}
	
	// Update is called once per frame
	void Update () {
        Shiprigidbody.AddForce(input.dir * moveForce);
	}
}
