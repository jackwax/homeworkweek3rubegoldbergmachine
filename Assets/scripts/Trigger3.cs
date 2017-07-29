using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour {

	Camera mc;

	// Use this for initialization
	void Start () {

		mc = Camera.main;
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){

		mc.transform.position = new Vector3 (13.11f, 97.09f, 63.93f);
		mc.transform.rotation = Quaternion.Euler (-9.158f, -108.25f, -0.802f);

	}
}
