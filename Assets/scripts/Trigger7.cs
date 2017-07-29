using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger7 : MonoBehaviour {

	Camera mc;

	// Use this for initialization
	void Start () {

		mc = Camera.main;
		
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		mc.transform.position = new Vector3 (2.22f, -159.9f, 291.7f);
		mc.transform.rotation = Quaternion.Euler (-84.982f, 167.948f, 12.611f);


	}
}
