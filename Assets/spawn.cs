using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject floor;
	public GameObject leftWall;
	public GameObject rightWall;
	private GameObject[] count;
	public static float thrust = -60;
	private Quaternion left = Quaternion.Euler (0, 180, 90);
	private Quaternion right = Quaternion.Euler (0, 0, 90);
	// Use this for initialization
	void Start () {
		Instantiate (rightWall, new Vector3 ((float)1.41,(float)-0.2005, (float)3.86), right );
		Instantiate(floor, new Vector3 ((float)0,(float) -0.5, (float)3.86), Quaternion.identity);

		Instantiate (leftWall, new Vector3 ((float)-1.45, (float)-0.2005, (float)3.86), left);
		Instantiate (rightWall, new Vector3 ((float)1.41,(float)-0.2005, (float)13.6), right);
		Instantiate(floor, new Vector3 ((float)0,(float) -0.5, (float)13.6), Quaternion.identity);

		Instantiate (leftWall, new Vector3 ((float)-1.45, (float)-0.2005, (float)13.6), left);
	}

	// Update is called once per frame
	void Update () {
		int c;
		count = GameObject.FindGameObjectsWithTag ("floor");
		c = count.Length;
		if (c < 2) {
			Instantiate (rightWall, new Vector3 ((float)1.41,(float)-0.2005, (float)13.6), right);
			Instantiate(floor, new Vector3 ((float)0,(float) -0.5, (float)13.6), Quaternion.identity);

			Instantiate (leftWall, new Vector3 ((float)-1.45, (float)-0.2005, (float)13.6), left);


		}
	}

}

