using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveupdown : MonoBehaviour {
	public float amplitude,speed;
	public Vector3 temppos;
	// Use this for initialization
	void Start () {
		temppos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		temppos.y = Mathf.Sin (Time.realtimeSinceStartup * speed) * amplitude + (float)0.5;
		transform.position = temppos;
	}
}
