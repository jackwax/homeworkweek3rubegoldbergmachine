using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

	public Camera mc;
	// Use this for initialization
	void Start () {
		mc = Camera.main;
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider col){
		Debug.Log ("Object has entered first trigger");
		mc.transform.position = new Vector3 (11.5f, 119.3f, 24.80f);
		mc.transform.rotation = Quaternion.Euler (0f, -154.58f, 0);
		}
}
