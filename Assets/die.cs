using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour {
	public Transform camera;
	public Vector3 temp;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag != "hand") {
			temp = camera.position;
			temp.x = 1.518f;
			temp.y = 0.962f;
			temp.z = -2.419f;
			camera.position = temp;
			Quaternion t = Quaternion.Euler (32.418f, -55.58f, -16.79f);
			camera.rotation = t;

			Time.timeScale = 0;
			Debug.Log (other.gameObject.name);
		}
}
}
