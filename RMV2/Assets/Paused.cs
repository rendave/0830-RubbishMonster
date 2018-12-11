using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Paused : MonoBehaviour {

	public Button giveUp;
	public Button resume;
	public Button restart;
	public Button menu;
	public Button option;
	public Button mission;


	public void giveUp_clicked() {
		Debug.Log ("Give up clicked.");
	}

	public void resume_clicked() {
		Debug.Log ("Resume clicked.");
	}

	public void restart_clicked() {
		Debug.Log ("Restart clicked.");
	}

	public void menu_clicked() {
		Debug.Log ("Menu clicked.");
	}

	public void option_clicked() {
		Debug.Log ("Option clicked.");
	}

	public void mission_clicked() {
		Debug.Log ("Mission clicked.");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
