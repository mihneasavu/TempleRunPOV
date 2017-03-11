using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameWhenCollide : MonoBehaviour {

	public bool strt = false;

	void OnTriggerEnter (Collider col)
	{
			strt = true;
		Debug.Log ("sihd");
			Destroy(col.gameObject);
	}

}
