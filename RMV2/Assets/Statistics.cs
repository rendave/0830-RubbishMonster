using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour {

    public Text total;
    public Text organic;
    public Text plastic;
    public Text hazard;
    public Text glass;
    public Text metal;
    public Text star;

    // Use this for initialization
    void Start () {
        total.text = PlayerPrefs.GetInt("total_rubbish_collected").ToString();
        organic.text = PlayerPrefs.GetInt("total_organic_collected").ToString();
        plastic.text = PlayerPrefs.GetInt("total_plastic_collected").ToString();
        hazard.text = PlayerPrefs.GetInt("total_hazard_collected").ToString();
        glass.text = PlayerPrefs.GetInt("total_glass_collected").ToString();
        metal.text = PlayerPrefs.GetInt("total_metal_collected").ToString();
        setStar();
    }
	
    void setStar()
    {
        int count = 0;
        if (PlayerPrefs.GetInt("level1_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level1_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level1_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level2_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level2_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level2_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level3_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level3_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level3_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level4_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level4_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level4_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level5_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level5_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level5_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level6_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level6_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level6_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level7_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level7_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level7_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level8_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level8_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level8_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level9_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level9_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level9_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level10_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level10_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level10_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level11_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level11_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level11_star3") == 1)
            count++;
        if (PlayerPrefs.GetInt("level12_star1") == 1)
            count++;
        if (PlayerPrefs.GetInt("level12_star2") == 1)
            count++;
        if (PlayerPrefs.GetInt("level12_star3") == 1)
            count++;
        star.text = count + "/36";
    }
	// Update is called once per frame
	void Update () {
		
	}
    
    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
}
