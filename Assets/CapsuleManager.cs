using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CapsuleManager : MonoBehaviour {
    public float rx;
    public float ry;
    public float rz;
    public float force;

    // Use this for initialization
    void Start () {
	rx = 0; ry = 0; rz = 1;
	force = 30;
    }
	
    // Update is called once per frame
    void FixedUpdate () {
	var rb = GetComponent<Rigidbody>();
	rb.AddForce(Quaternion.identity);
	rb.AddTorque( force * new Vector3(rx, ry, rz));
	if (Input.GetMouseButton(0)) rb.AddForce( force * new Vector3(0, 1, 0), ForceMode.Impulse);
    }
}
