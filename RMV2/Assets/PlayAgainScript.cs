using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgainScript : MonoBehaviour {

	public Image[] star;
	private int count = 0;
	private float speed = 100;
	private float current = 0;
	private int rate = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count < rate) {
			if (current < 100) {
				current += speed * Time.deltaTime;
				star [count].fillAmount = current / 100;
			} 
			else {
				current = 0;
				count++;
			}
		}
	}

	public void nextClicked(){
		// code here
		Debug.Log("Next Clicked");
	}

	public void retryClicked(){
		// code here
		Debug.Log("Retry Clicked");
	}

}
