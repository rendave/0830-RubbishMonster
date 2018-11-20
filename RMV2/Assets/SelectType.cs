using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectType : MonoBehaviour {

	public Button btnDaily;
	public Button btnSpecial;
	public GameObject dailyP;
	public GameObject specialP;


	// Use this for initialization
	void Start () {
		switchDaily ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void switchSpecial() {
		dailyP.SetActive (false);
		specialP.SetActive (true);
	}

	public void switchDaily() {
		dailyP.SetActive (true);
		specialP.SetActive (false);
	}
}
