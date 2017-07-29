using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger4 : MonoBehaviour {

	// Use this for initialization
	Camera mc;

	void Start () {
		mc = Camera.main;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){

		Debug.Log ("Object has entered the fourth trigger");

		mc.transform.position = new Vector3 (55.28f, 76f, 76.03f);
		mc.transform.rotation = Quaternion.Euler (29.961f, 287.842f, 6.797f);


	}
}
