using UnityEngine;
using System.Collections;

public class AccellerometerInput : MonoBehaviour {

    [HideInInspector]
    public Vector3 dir = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        //dir.y = Input.acceleration.y;
        //dir.z = Input.acceleration.z;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();
	}
}
