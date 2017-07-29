using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger10 : MonoBehaviour {

	// Use this for initialization
	Camera mc;
	GameObject endSphere;
	void Start () {

		mc = Camera.main;
		endSphere = GameObject.Find ("endSphere");
		
	}
	
	void OnTriggerEnter(Collider col){
		Debug.Log ("Trigger 10 has been reached");
		mc.transform.position = new Vector3 (-0.56f, -160.52f, 363.94f);
		mc.transform.rotation = Quaternion.Euler (45.316f, -353.78f, 3.785f);
		//mc.transform.parent = endSphere.transform;
		//mc.transform.rotation = Quaternion.Euler (0, 0, 0);
	}
}
