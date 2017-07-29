using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private Button StartButton;

	public GameObject EndText;

	public GameObject startSphere;

	// Use this for initialization
	void Start () {
		startSphere = GameObject.Find ("startSphere");

		EndText = GameObject.Find ("EndText");

		EndText.SetActive (false);


		StartButton = GameObject.Find ("StartButton").GetComponent<Button>();
		StartButton.onClick.AddListener (GameStart);

		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void GameStart(){
		StartButton.gameObject.SetActive (false);
		startSphere.GetComponent<Rigidbody> ().useGravity = true;
	}
}
