using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public Rigidbody rb;
	public Vector3 temp;
	public float thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(0,0,thrust,ForceMode.Force);
	}
	
	// Update is called once per frame
	void Update () {
		
		temp = transform.position;
		if (temp.z <= -16 || temp.x <=-200|| temp.x >=200 || temp.z >=200 ||temp.x <=-200 || temp.x >=200) {
			Destroy (this.gameObject);
			spawn.nou = true;
		}
		//rb.AddForce(0,0,thrust,ForceMode.Force);


	}
}
