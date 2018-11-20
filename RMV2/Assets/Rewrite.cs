using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Rewrite : MonoBehaviour
{
	public RawImage check;
	public RawImage pen;
	public InputField write;

	public Text petName;


	void Start(){
		check.enabled = false;
		write.interactable = false;
		//petName.text = Pets.pets.name;
		//Debug.Log (Pets.pets.name);
	}
	
	public void penClicked()
    {
		check.enabled = true;
		pen.enabled = false;
		write.interactable = true;
    }

	public void checkClicked()
	{
		check.enabled = false;
		pen.enabled = true;
		write.interactable = false;
        //Pets.pets.name = petName.text;
        //Debug.Log (petName.text);

        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {
            case "M1":
                PlayerPrefs.SetString("pet1", petName.text);
                break;
            case "M2":
                PlayerPrefs.SetString("pet2", petName.text);
                break;
            case "M3":
                PlayerPrefs.SetString("pet3", petName.text);
                break;
            case "M4":
                PlayerPrefs.SetString("pet4", petName.text);
                break;
            case "M5":
                PlayerPrefs.SetString("pet5", petName.text);
                break;
        }
    }

}
