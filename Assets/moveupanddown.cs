using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveupanddown : MonoBehaviour {
		public float amplitude,speed;

	public Vector3 temppos;
	public Vector3 temppos2;
	public float height;
	private bool ok3 = true;
	private bool ok2 = true;
	private bool ok = true;
	private int nr =0;

		// Use this for initialization
		void Start () {
			temppos = transform.position;
			}
		
		// Update is called once per frame
		void Update () {
		//if(!ok2) Debug.Log (ok2);

			/*temppos.y = Mathf.Sin (Time.realtimeSinceStartup * speed) * amplitude + (float)0.5;
			transform.position = temppos;*/
		}
	}
	