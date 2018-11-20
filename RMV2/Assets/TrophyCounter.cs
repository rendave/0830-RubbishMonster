using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrophyCounter : MonoBehaviour {

    public Text trophyCount;
    public Slider slider;

	// Use this for initialization
	void Start () {
        trophyCount.text = PlayerPrefs.GetInt("trophies").ToString() + "/3";
        slider.value = calculate();
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

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
    float calculate()
    {
        return PlayerPrefs.GetInt("trophies") / 3f;
    }
}
