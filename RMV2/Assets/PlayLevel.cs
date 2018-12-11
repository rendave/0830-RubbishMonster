using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayLevel : MonoBehaviour {

    public Text level;
    public Text score;
    public RawImage star1;
    public RawImage star2;
    public RawImage star3;

    int currentLevel, currentScore;
    int str1, str2, str3;
    // Use this for initialization
    void Start () {
        currentLevel = PlayerPrefs.GetInt("current_level");
        currentScore = PlayerPrefs.GetInt("current_score");
        str1 = PlayerPrefs.GetInt("current_star1");
        str2 = PlayerPrefs.GetInt("current_star2");
        str3 = PlayerPrefs.GetInt("current_star3");
        if(str1 == 1)
            star1.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
        if (str2 == 1)
            star2.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
        if (str3 == 1)
            star3.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);

        level.text = "LEVEL "+currentLevel;
        score.text = currentScore.ToString();
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

    

    public void exit()
    {
        SceneManager.LoadScene("MENU");
    }

    public void play()
    {
        Debug.Log("Playing level now.");
        SceneManager.LoadScene("GAMEPLAY");
    }
}
