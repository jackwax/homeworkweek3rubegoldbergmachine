using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour {

	public Camera mc;
	// Use this for initialization
	void Start () {
		mc = Camera.main;
		
	}
	
	void OnTriggerEnter(Collider col){
		mc.transform.position = new Vector3 (26.19f, 117.92f, 30.84f);
		mc.transform.rotation = Quaternion.Euler (0, 274.865f, 0);
	}
}
