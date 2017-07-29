using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTurn : MonoBehaviour {

	bool ballIn = false;
	Camera mc;
	GameObject startSphere;

	// Use this for initialization

	public GameObject basket;
	void Start () {
		mc = Camera.main;
		startSphere = GameObject.Find ("startSphere");
		basket = GameObject.Find ("basket");
	}

	// Update is called once per frame
	void Update () {
		if (ballIn == true) {
			basket.transform.Rotate (0.4f, 0, 0);
		}
		
	}

	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "ball") {
			Destroy (startSphere);
			
			Debug.Log ("Object has entered the trigger");
			mc.transform.position = new Vector3 (8.5f, 46.4f, 190.2f);
			mc.transform.rotation = Quaternion.Euler (29.961f, -144.272f, 0);
			Debug.Log ("This line of code has been reached");
			ballIn = true;
		}

	}

	void OnTriggerStay (Collider col){
		if (col.gameObject.tag == "ball"){
			
			Debug.Log ("Object is within Trigger");
		}
	}
}
