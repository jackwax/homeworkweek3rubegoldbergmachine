using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger8 : MonoBehaviour {

	Camera mc;

	// Use this for initialization
	void Start () {

		mc = Camera.main;
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		mc.transform.position = new Vector3 (34.14f, -150.2f, 292.99f);
		mc.transform.rotation = Quaternion.Euler (8.57f, -66.257f, 0);
	}
}
