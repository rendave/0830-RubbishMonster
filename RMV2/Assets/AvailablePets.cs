using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailablePets : MonoBehaviour {

    public GameObject pet1;
    public GameObject pet2;
    public GameObject pet3;
    public GameObject pet4;
    public GameObject pet5;

    // Use this for initialization
    void Start () {
        pet3.SetActive(false);
        pet4.SetActive(false);
        pet5.SetActive(false);
        petAvail();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void petAvail()
    {
        if (PlayerPrefs.GetInt("pet3Unlocked") == 1)
        {
            pet3.SetActive(true);
            PlayerPrefs.SetInt("pet3_active", 1);
        }
            
        if (PlayerPrefs.GetInt("pet4Unlocked") == 1)
        {
            pet4.SetActive(true);
            PlayerPrefs.SetInt("pet4_active", 1);
        }
            
        if (PlayerPrefs.GetInt("pet5Unlocked") == 1)
        {
            pet5.SetActive(true);
            PlayerPrefs.SetInt("pet5_active", 1);
        }
            
    }
}
