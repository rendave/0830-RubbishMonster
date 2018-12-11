using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("MENU");
                return;
            }
        }
    }

	public void aboutClicked(){
        SceneManager.LoadScene("ABOUT");
	}

	public void creditsClicked(){
        SceneManager.LoadScene("CREDITS");
	}

	public void musicOn(Toggle music){
		if (music.isOn) {
			Debug.Log ("Music On");
            AudioListener.volume = 1.0F;
        }
        else {
			Debug.Log ("Music Off");
            AudioListener.volume = 0.0F;
        }	
	}
    public void back()
    {
        SceneManager.LoadScene("MENU");
    }

    public void back1()
    {
        SceneManager.LoadScene("OptionScene");
    }
}
