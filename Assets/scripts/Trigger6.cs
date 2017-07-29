using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger6 : MonoBehaviour {

	Camera mc;
	// Use this for initialization
	void Start () {
		mc = Camera.main;
	}
	
	void OnTriggerEnter(Collider col){
		mc.transform.position = new Vector3 (2.22f, -89.6f, 319.1f);
		mc.transform.rotation = Quaternion.Euler (-10.095f, 178.937f, 0.789f);
	}
}
