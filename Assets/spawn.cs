using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject floor;
	public GameObject leftWall;
	public GameObject rightWall;
	public GameObject stick;
	public GameObject stickh;
	public GameObject ball;
	private GameObject[] count;

	private Quaternion left = Quaternion.Euler (0, 180, 90);
	private Quaternion right = Quaternion.Euler (0, 0, 90);
	public float startWait = 3;
	public static bool nou = false;

	private void spawnn(float x)
	{	
		
		Instantiate (rightWall, new Vector3 ((float)1.41,(float)-0.2005, x), right );
		Instantiate(floor, new Vector3 ((float)0,(float) -0.5, x), Quaternion.identity);
		Instantiate(leftWall, new Vector3((float)-1.41,-0.2005f,x),left);
	}
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
		Instantiate (stick, new Vector3 (0, 0, 8), Quaternion.identity);
		spawnn (3.86f);
		spawnn (23f);
		spawnn (42.3f);
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
			if (startWait >1)
				startWait-=0.1f;
		while (true)
		{
			Instantiate (ball, new Vector3 (Random.Range (-0.89f, 0.83f), 0, Random.Range (2f, 10f)), Quaternion.identity);
			Instantiate (ball, new Vector3 (Random.Range (-0.89f, 0.83f), 0, Random.Range (2f, 10f)), Quaternion.identity);

				int s = Random.Range (1, 3);

				switch (s) {

				case 1:
					Instantiate (stickh, new Vector3 (Random.Range (-0.89f, 0.83f), 0, Random.Range (2f, 10f)), Quaternion.identity);
					break;
				case 2:
					Instantiate (stickh, new Vector3 (Random.Range (-0.89f, 0.83f), 0, Random.Range (2f, 10f)), Quaternion.Euler (0, 0, Random.Range (-180, 180)));
					break;
				case 3:
					Instantiate (stickh, new Vector3 (0, Random.Range (0.30f, 0.5f), Random.Range (2f, 10f)), Quaternion.identity);
					break;
				}
		
			yield return new WaitForSeconds(startWait);
				if (startWait >1)
					startWait-=0.1f;
		}
		
	}


	// Update is called once per frame
	void Update () {
		
		int c;
		count = GameObject.FindGameObjectsWithTag ("floor");
		c = count.Length;
		if (nou) {
			spawnn (42.3f);
			nou = false;
		}
	}

}

