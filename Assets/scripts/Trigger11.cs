using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger11 : MonoBehaviour {

	Camera mc;

	// Use this for initialization
	void Start () {
		mc = Camera.main;
		
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		mc.transform.position = new Vector3 (91.1f, -198.5f, 620.2f);
		mc.transform.rotation = Quaternion.Euler (48.757f, -78.088f, 4.748f);
	}
}
