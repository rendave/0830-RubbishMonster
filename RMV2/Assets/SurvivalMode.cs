using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalMode : MonoBehaviour {

    public Text highscore;

	// Use this for initialization
	void Start () {
        highscore.text = PlayerPrefs.GetInt("survival_score").ToString();
    }
	
    public void play()
    {
        SceneManager.LoadScene("GAMEPLAYSURVIVAL");
    }

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
}
