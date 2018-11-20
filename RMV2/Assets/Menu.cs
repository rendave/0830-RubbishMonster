using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Text coins;
    public Text gems;
    public Text medalName;
    public Slider experienceBar;

    public GameObject medals;
    public GameObject trophies;
    public GameObject guide;
    public GameObject options;
    public GameObject mission;
    public GameObject pets;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    public GameObject level10;
    public GameObject level11;
    public GameObject level12;
    public GameObject survival;

    public GameObject fact;
    public Text factwhat;

    public GameObject cont;
    public Text tuts;
    string[] mess;
    int ctr = 0;

    // images
    public GameObject img0;
    public GameObject img11;
    public GameObject img12;
    public GameObject img13;
    public GameObject img14;
    public GameObject img15;
    public GameObject img31;
    public GameObject img32;
    public GameObject img33;
    public GameObject img34;
    public GameObject img35;
    public GameObject img41;
    public GameObject img51;
    public GameObject img52;
    public GameObject img61;
    public GameObject img62;
    public GameObject img63;
    public GameObject img71;
    public GameObject img81;
    public GameObject img91;
    public GameObject img92;
    public GameObject img101;
    public GameObject img102;

    public void factclicked()
    {
        Destroy(fact);
    }

    public void tutorials()
    {
        int cur = PlayerPrefs.GetInt("messNum");
        if(cur < 11)
        {
            switch (cur)
            {
                case 0:
                    tuts.text = PlayerPrefs.GetString("mess0");
                    break;
                case 1:
                    tuts.text = PlayerPrefs.GetString("mess1");
                    break;
                case 2:
                    tuts.text = PlayerPrefs.GetString("mess2");
                    img0.SetActive(false);
                    img11.SetActive(true);
                    img12.SetActive(true);
                    img13.SetActive(true);
                    img14.SetActive(true);
                    img15.SetActive(true);
                    break;
                case 3:
                    tuts.text = PlayerPrefs.GetString("mess3");
                    img31.SetActive(true);
                    img32.SetActive(true);
                    img33.SetActive(true);
                    img34.SetActive(true);
                    img35.SetActive(true);
                    break;
                case 4:
                    tuts.text = PlayerPrefs.GetString("mess4");
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img31.SetActive(false);
                    img32.SetActive(false);
                    img33.SetActive(false);
                    img34.SetActive(false);
                    img35.SetActive(false);
                    img41.SetActive(true);
                    break;
                case 5:
                    tuts.text = PlayerPrefs.GetString("mess5");
                    img41.SetActive(false);
                    img51.SetActive(true);
                    img52.SetActive(true);
                    break;
                case 6:
                    tuts.text = PlayerPrefs.GetString("mess6");
                    img61.SetActive(true);
                    img62.SetActive(true);
                    img63.SetActive(true);
                    break;
                case 7:
                    tuts.text = PlayerPrefs.GetString("mess7");
                    img51.SetActive(false);
                    img52.SetActive(false);
                    img61.SetActive(false);
                    img62.SetActive(false);
                    img63.SetActive(false);
                    img71.SetActive(true);
                    break;
                case 8:
                    tuts.text = PlayerPrefs.GetString("mess8");
                    img71.SetActive(false);
                    img81.SetActive(true);
                    break;
                case 9:
                    tuts.text = PlayerPrefs.GetString("mess9");
                    img91.SetActive(true);
                    img92.SetActive(true);
                    break;
                case 10:
                    tuts.text = PlayerPrefs.GetString("mess10");
                    img81.SetActive(false);
                    img91.SetActive(false);
                    img92.SetActive(false);
                    img101.SetActive(true);
                    img102.SetActive(true);
                    break;
            }
            PlayerPrefs.SetInt("messNum", PlayerPrefs.GetInt("messNum") + 1);
        }
        else
        {
            Destroy(cont);
            PlayerPrefs.SetInt("tutorial", 0);
        }
    }
    // Use this for initialization
    void Start () {
        cont.SetActive(false);
        coins.text = PlayerPrefs.GetInt("coins").ToString();
        gems.text = PlayerPrefs.GetInt("gems").ToString();
        setMedal();
        unlockPets();
        medalName.text = PlayerPrefs.GetString("medal");
        loadLevels();
        int ah = Random.Range(0, 8);
        if (PlayerPrefs.GetInt("tutorial") == 1)
        {
            cont.SetActive(true);
            img11.SetActive(false);
            img12.SetActive(false);
            img13.SetActive(false);
            img14.SetActive(false);
            img15.SetActive(false);
            img31.SetActive(false);
            img32.SetActive(false);
            img33.SetActive(false);
            img34.SetActive(false);
            img35.SetActive(false);
            img41.SetActive(false);
            img51.SetActive(false);
            img52.SetActive(false);
            img61.SetActive(false);
            img62.SetActive(false);
            img63.SetActive(false);
            img71.SetActive(false);
            img81.SetActive(false);
            img91.SetActive(false);
            img92.SetActive(false);
            img101.SetActive(false);
            img102.SetActive(false);   
            tutorials();
            fact.SetActive(false);
        }
        else
        {
            fact.SetActive(true);
            if (ah == 0)
            {
                factwhat.text = PlayerPrefs.GetString("m1"); ;
            }
            else if (ah == 1)
            {
                factwhat.text = PlayerPrefs.GetString("m2"); ;
            }
            else if (ah == 2)
            {
                factwhat.text = PlayerPrefs.GetString("m3"); ;
            }
            else if (ah == 3)
            {
                factwhat.text = PlayerPrefs.GetString("m4"); ;
            }
            else if (ah == 4)
            {
                factwhat.text = PlayerPrefs.GetString("m5"); ;
            }
            else if (ah == 5)
            {
                factwhat.text = PlayerPrefs.GetString("m6"); ;
            }
            else
            {
                factwhat.text = PlayerPrefs.GetString("m7"); ;
            }
        }
        Instantiate(fact);
}
	
	// Update is called once    per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();

                return;
            }
        }
    }

    void unlockPets()
    {
        if (PlayerPrefs.GetString("medal") == "COLLECTOR")
            PlayerPrefs.SetInt("pet3Unlocked", 1);
        if (PlayerPrefs.GetString("medal") == "LEADER")
            PlayerPrefs.SetInt("pet4Unlocked", 1);
        if (PlayerPrefs.GetString("medal") == "MANAGER")
            PlayerPrefs.SetInt("pet5Unlocked", 1);
    }

    void setMedal()
    {
        int e = PlayerPrefs.GetInt("exp");
        if(e > 800)
        {
            experienceBar.value = 1f;
            PlayerPrefs.SetString("medal", "BOSS");
        }
        else if (e > 600)
        {
            experienceBar.value = (200 - (800f - e)) / 200;
            PlayerPrefs.SetString("medal", "MANAGER");
        }
        else if (e > 400)
        {
            experienceBar.value = (200 - (600f - e)) / 200;
            PlayerPrefs.SetString("medal", "LEADER");
        }
        else if (e > 200)
        {
            experienceBar.value = (200 - (400f - e)) / 200;
            PlayerPrefs.SetString("medal", "COLLECTOR");
        }
        else
        {
            experienceBar.value = (200 - (200f - e)) / 200;
        }
    }
    

    void loadLevels()
    {
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);
        level11.SetActive(false);
        level12.SetActive(false);
        survival.SetActive(false);
        if (PlayerPrefs.GetInt("level1_done") == 1)
            level2.SetActive(true);
        if (PlayerPrefs.GetInt("level2_done") == 1)
            level3.SetActive(true);
        if (PlayerPrefs.GetInt("level3_done") == 1)
            level4.SetActive(true);
        if (PlayerPrefs.GetInt("level4_done") == 1)
            level5.SetActive(true);
        if (PlayerPrefs.GetInt("level5_done") == 1)
            level6.SetActive(true);
        if (PlayerPrefs.GetInt("level6_done") == 1)
            level7.SetActive(true);
        if (PlayerPrefs.GetInt("level7_done") == 1)
            level8.SetActive(true);
        if (PlayerPrefs.GetInt("level8_done") == 1)
        {
            level9.SetActive(true);
            survival.SetActive(true);
        }
            
        if (PlayerPrefs.GetInt("level9_done") == 1)
            level10.SetActive(true);
        if (PlayerPrefs.GetInt("level10_done") == 1)
            level11.SetActive(true);
        if (PlayerPrefs.GetInt("level11_done") == 1)
            level12.SetActive(true);
    }

    public void medalCliked()
    {
        SceneManager.LoadScene("MEDALS");
    }

    public void trophiesCliked()
    {
        SceneManager.LoadScene("TROPHIES");
    }

    public void guideCliked()
    {
        PlayerPrefs.SetInt("tutorial", 1);
        PlayerPrefs.SetInt("messNum", 0);
        SceneManager.LoadScene("MENU");
    }

    public void optionsCliked()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void petsCliked()
    {
        SceneManager.LoadScene("PETS");
    }

    public void missionsCliked()
    {
        SceneManager.LoadScene("MISSION");
    }

    public void statsCliked()
    {
        SceneManager.LoadScene("STATS");
    }

    public void level1Cliked()
    {
        PlayerPrefs.SetInt("current_level", 1);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level1_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level1_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level1_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level1_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level1_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level1_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level2Cliked()
    {
        PlayerPrefs.SetInt("current_level", 2);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level2_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level2_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level2_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level2_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level2_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level2_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level3Cliked()
    {
        PlayerPrefs.SetInt("current_level", 3);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level3_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level3_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level3_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level3_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level3_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level3_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level4Cliked()
    {
        PlayerPrefs.SetInt("current_level", 4);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level4_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level4_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level4_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level4_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level4_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level4_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level5Cliked()
    {
        PlayerPrefs.SetInt("current_level", 5);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level5_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level5_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level5_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level5_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level5_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level5_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level6Cliked()
    {
        PlayerPrefs.SetInt("current_level", 6);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level6_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level6_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level6_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level6_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level6_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level6_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level7Cliked()
    {
        PlayerPrefs.SetInt("current_level", 7);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level7_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level7_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level7_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level7_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level7_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level7_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level8Cliked()
    {
        PlayerPrefs.SetInt("current_level", 8);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level8_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level8_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level8_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level8_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level8_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level8_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level9Cliked()
    {
        PlayerPrefs.SetInt("current_level", 9);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level9_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level9_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level9_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level9_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level9_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level9_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level10Cliked()
    {
        PlayerPrefs.SetInt("current_level", 10);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level10_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level10_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level10_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level10_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level10_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level10_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level11Cliked()
    {
        PlayerPrefs.SetInt("current_level", 11);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level11_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level11_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level11_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level11_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level11_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level11_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void level12Cliked()
    {
        PlayerPrefs.SetInt("current_level", 12);
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level12_score"));
        PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level12_star1"));
        PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level12_star2"));
        PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level12_star3"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("level12_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("level12_time"));
        SceneManager.LoadScene("PLAY");
    }

    public void survivalCliked()
    {
        SceneManager.LoadScene("PLAYSURVIVAL");
        PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("survival_score"));
        PlayerPrefs.SetInt("current_level_count", PlayerPrefs.GetInt("survival_count"));
        PlayerPrefs.SetInt("current_level_time", PlayerPrefs.GetInt("survival_time"));
    }
}
