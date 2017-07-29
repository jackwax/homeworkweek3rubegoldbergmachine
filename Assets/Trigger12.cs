using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger12 : MonoBehaviour {

	GameObject EndText;

	// Use this for initialization
	void Start () {

		EndText = GameObject.Find ("EndText");
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		EndText.SetActive (true);
	}
}
