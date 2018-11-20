using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Missions : MonoBehaviour {

    public Button daily;
    public Button special;

    public GameObject pnlDaily;
    public GameObject pnlSpecial;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
}
