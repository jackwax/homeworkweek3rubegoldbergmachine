using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger9 : MonoBehaviour {

	// Use this for initialization
	Camera mc;
	void Start () {
		mc = Camera.main;
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider col){
		Debug.Log ("Trigger 9 has been reached");
		mc.transform.position = new Vector3 (43.53f, -142.6f, 343.03f);
		mc.transform.rotation = Quaternion.Euler (23.571f, -64.254f, 0);
	}
}
