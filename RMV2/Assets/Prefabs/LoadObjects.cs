using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadObjects : MonoBehaviour {

    public GameObject type1;
    public GameObject type2;
    public GameObject type3;
    public GameObject type4;
    public GameObject type5;

    public GameObject type11;
    public GameObject type21;
    public GameObject type31;
    public GameObject type41;
    public GameObject type51;

    public GameObject type13;
    public GameObject type14;
    public GameObject type15;

    public GameObject type23;
    public GameObject type24;
    public GameObject type25;

    public GameObject type33;
    public GameObject type34;
    public GameObject type35;

    public GameObject type43;
    public GameObject type44;
    public GameObject type45;

    public GameObject type53;
    public GameObject type54;
    public GameObject type55;


    public Text level;
    public Text remaining;
    public Text life;
    public Text score;
    public RawImage bg;

    public GameObject correct;
    public GameObject error;
    //public GameObject message;
    public GameObject endmusic;
    public GameObject failed;

    public GameObject start;
    public GameObject end;

    public RawImage star1;
    public RawImage star2;
    public RawImage star3;

    public Text endScore;

    GameObject objectClone;
    int count;
    int speed;
    int[] random;
    int range;
    bool canclick = false;
    bool missed = true;
    bool finish = false;
    int ctr = 0;
    float grav;
    
    public GameObject pausing;
    public Button continuing;
    public Button giveUp;

    // Use this for initialization
    void Start () {
        //Instantiate(message);
        end.SetActive(false);
        pausing.SetActive(false);
        //StartCoroutine(Spawner());
    }

    private AudioSource[] allAudioSources;

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            //audioS.Stop();
        }
    }

    public void pause()
    {
        Time.timeScale = 0;
        objectClone.SetActive(false);
        pausing.SetActive(true);
    }

    public void continued()
    {
        Time.timeScale = 1;
        objectClone.SetActive(true);
        pausing.SetActive(false);
    }

    public void give_up()
    {
        PlayerPrefs.SetInt("gameOn",0);
        pausing.SetActive(false);
    }

    public void startClicked()
    {
        PlayerPrefs.SetInt("gameOn", 1);
        score.text = "0";
        level.text = "Level " + PlayerPrefs.GetInt("current_level");
        rangeSetter();
        range = PlayerPrefs.GetInt("range");
        count = PlayerPrefs.GetInt("current_level_count");
        remaining.text = count.ToString();
        speed = PlayerPrefs.GetInt("current_level_time");
        if (speed == 4)
            grav = -100f;
        else if (speed == 3)
            grav = -200f;
        else if (speed == 2)
            grav = -300f;
        else if (speed == 1)
            grav = -400f;
        Physics2D.gravity = new Vector3(grav, 0f, 0f);
        bg.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
        randomizer();
        Destroy(start);
        StopAllAudio();
    }
    
    bool exist = false;
	// Update is called once per frame
	void Update () {
        if (!exist)
        {
            Debug.Log("SIFAS");
            if (ctr < count && PlayerPrefs.GetInt("gameOn") == 1)
            {
                canclick = true;
                Debug.Log("Bam");
                Debug.Log("Current Type = " + random[ctr]);
                int z = Random.Range(0, 5);
                if ((ctr > 0) && missed)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    if (int.Parse(life.text) == 0)
                    {
                    }
                }

                missed = true;
                switch (random[ctr])
                {
                    case 1:
                        if (z == 0)
                        {
                            objectClone = Instantiate(type1, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 1)
                        {
                            objectClone = Instantiate(type11, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 2)
                        {
                            objectClone = Instantiate(type13, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 3)
                        {
                            objectClone = Instantiate(type14, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                        }
                        else
                        {
                            objectClone = Instantiate(type15, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        PlayerPrefs.SetInt("current_type", 1);
                        break;
                    case 2:
                        if (z == 0)
                        {
                            objectClone = Instantiate(type2, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if(z == 1)
                        {
                            objectClone = Instantiate(type21, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(450f, 450f, 0f);
                        }
                        else if (z == 2)
                        {
                            objectClone = Instantiate(type23, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(300f, 300f, 0f);
                        }
                        else if (z == 3)
                        {
                            objectClone = Instantiate(type24, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(300f, 300f, 0f);
                        }
                        else
                        {
                            objectClone = Instantiate(type25, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(300f, 300f, 0f);
                        }
                        PlayerPrefs.SetInt("current_type", 2);
                        break;
                    case 3:
                        if (z == 0)
                        {
                            objectClone = Instantiate(type3, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 1)
                        {
                            objectClone = Instantiate(type31, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 2)
                        {
                            objectClone = Instantiate(type33, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(1000f, 1000f, 0f);
                        }
                        else if (z == 3)
                        {
                            objectClone = Instantiate(type34, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        } 
                        else
                        {
                            objectClone = Instantiate(type35, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(500f, 500f, 0f);
                        }
                        PlayerPrefs.SetInt("current_type", 3);
                        break;
                    case 4:
                        if (z == 0)
                        {
                            objectClone = Instantiate(type4, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(50f, 50f, 0f);
                        }
                        else if(z == 1)
                        {
                            objectClone = Instantiate(type41, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(500f, 500f, 0f);
                        }
                        else if (z == 2)
                        {
                            objectClone = Instantiate(type43, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(500f, 500f, 0f);
                        }
                        else if (z == 3)
                        {
                            objectClone = Instantiate(type44, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(100f, 100f, 0f);
                        }
                        else
                        {
                            objectClone = Instantiate(type45, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(500f, 500f, 0f);
                        }
                        PlayerPrefs.SetInt("current_type", 4);
                        break;
                    case 5:
                        if (z == 0)
                        {
                            objectClone = Instantiate(type5, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                        }
                        else if(z == 1)
                        {
                            objectClone = Instantiate(type51, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 2)
                        {
                            objectClone = Instantiate(type53, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else if (z == 3)
                        {
                            objectClone = Instantiate(type54, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                        }
                        else
                        {
                            objectClone = Instantiate(type55, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                            objectClone.transform.localScale = new Vector3(150f, 150f, 0f);
                        }
                        PlayerPrefs.SetInt("current_type", 5);
                        break;
                }
                exist = true;
                ctr++;
                remaining.text = (int.Parse(remaining.text) - 1).ToString();
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
            }
        }

        Vector3 screenPoint = Camera.main.WorldToViewportPoint(objectClone.transform.position);
        bool onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;

        //Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(!onScreen)
        {
            bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
            Destroy(objectClone);
            exist = false;
            Instantiate(error);
            if (int.Parse(life.text) == 1 || int.Parse(remaining.text) == 0)
            {
                PlayerPrefs.SetInt("gameOn",0);
            }
        }


            // end of game here
        if (PlayerPrefs.GetInt("gameOn") == 0)
        {
            saveScore();
            Debug.Log(PlayerPrefs.GetInt("current_level"));
            switch (PlayerPrefs.GetInt("current_level"))
            {
                case 1:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level1_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level1_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level1_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level1_star3"));
                    break;
                case 2:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level2_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level2_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level2_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level2_star3"));
                    break;
                case 3:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level3_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level3_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level3_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level3_star3"));
                    break;
                case 4:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level4_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level4_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level4_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level4_star3"));
                    break;
                case 5:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level5_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level5_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level5_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level5_star3"));
                    break;
                case 6:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level6_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level6_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level6_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level6_star3"));
                    break;
                case 7:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level7_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level7_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level7_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level7_star3"));
                    break;
                case 8:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level8_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level8_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level8_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level8_star3"));
                    break;
                case 9:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level9_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level9_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level9_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level9_star3"));
                    break;
                case 10:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level10_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level10_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level10_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level10_star3"));
                    break;
                case 11:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level11_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level11_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level11_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level11_star3"));
                    break;
                case 12:
                    PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level12_score"));
                    PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level12_star1"));
                    PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level12_star2"));
                    PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level12_star3"));
                    break;
            }
            end.SetActive(true);
            endScore.text = score.text;
            int passingScore = (300 * count) / 2;
            if (int.Parse(endScore.text) > passingScore)
            {
                star1.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
                Instantiate(endmusic);
                if (int.Parse(endScore.text) > (passingScore*2))
                {
                    star2.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
                    if (int.Parse(endScore.text) > passingScore*3)
                        star3.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
                }
            }
            else
            {
                Instantiate(failed);
            }
        }
    }

    public void ends()
    {
        SceneManager.LoadScene("PLAY");
    }

    /*
    public IEnumerator Spawner()
    {
        Debug.Log(count);
        
        while (ctr < count)
        {
            canclick = true;
            bg.GetComponent<RawImage>().color = new Color32(255, 255, 255, 255);
            
            Debug.Log("Bam");
            Debug.Log("Current Type = " + random[ctr]);
            int z = Random.Range(0, 2);
            if ((ctr > 0) && missed)
            {
                life.text = (int.Parse(life.text) - 1).ToString();
                if(int.Parse(life.text) == 0 )
                {
                    break;
                }
            }
                
            missed = true;
            switch (random[ctr])
            {
                case 1:
                    if(z == 0)
                        objectClone = Instantiate(type1, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                    else
                        objectClone = Instantiate(type11, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                    PlayerPrefs.SetInt("current_type", 1);
                    break;
                case 2:
                    if (z == 0)
                    {
                        objectClone = Instantiate(type2, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                    }
                    else
                    {
                        objectClone = Instantiate(type21, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(500f, 500f, 0f);
                    }
                    PlayerPrefs.SetInt("current_type", 2);
                    break;
                case 3:
                    if (z == 0)
                        objectClone = Instantiate(type3, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                    else
                        objectClone = Instantiate(type31, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                    PlayerPrefs.SetInt("current_type", 3);
                    break;
                case 4:
                    if (z == 0)
                    {
                        objectClone = Instantiate(type4, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(50f, 50f, 0f);
                    }
                    else
                    {
                        objectClone = Instantiate(type41, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(700f, 700f, 0f);
                    }
                    PlayerPrefs.SetInt("current_type", 4);
                    break;
                case 5:
                    if (z == 0)
                    {
                        objectClone = Instantiate(type5, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                    }
                    else
                    {
                        objectClone = Instantiate(type51, new Vector3(2200f, 5f, 0f), transform.rotation) as GameObject;
                        objectClone.transform.localScale = new Vector3(200f, 200f, 0f);
                    }
                    PlayerPrefs.SetInt("current_type", 5);
                    break;
            }
            ctr++;
            remaining.text = (int.Parse(remaining.text) - 1).ToString();
            yield return new WaitForSeconds(speed);
        }

        // end of game here
        saveScore();
        switch(PlayerPrefs.GetInt("current_level"))
        {
            case 1:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level1_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level1_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level1_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level1_star3"));
                break;
            case 2:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level2_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level2_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level2_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level2_star3"));
                break;
            case 3:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level3_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level3_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level3_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level3_star3"));
                break;
            case 4:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level4_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level4_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level4_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level4_star3"));
                break;
            case 5:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level5_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level5_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level5_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level5_star3"));
                break;
            case 6:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level6_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level6_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level6_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level6_star3"));
                break;
            case 7:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level7_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level7_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level7_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level7_star3"));
                break;
            case 8:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level8_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level8_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level8_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level8_star3"));
                break;
            case 9:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level9_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level9_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level9_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level9_star3"));
                break;
            case 10:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level10_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level10_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level10_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level10_star3"));
                break;
            case 11:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level11_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level11_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level11_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level11_star3"));
                break;
            case 12:
                PlayerPrefs.SetInt("current_score", PlayerPrefs.GetInt("level12_score"));
                PlayerPrefs.SetInt("current_star1", PlayerPrefs.GetInt("level12_star1"));
                PlayerPrefs.SetInt("current_star2", PlayerPrefs.GetInt("level12_star2"));
                PlayerPrefs.SetInt("current_star3", PlayerPrefs.GetInt("level12_star3"));
                break;
        }
        
        SceneManager.LoadScene("PLAY");
        
}*/

    void saveScore()
    {
        Debug.Log("Proceeding to saveScore()");
        int lvl = PlayerPrefs.GetInt("current_level");
        int curScore = int.Parse(score.text);
        int passingScore = (300 * count)/2;
        switch(lvl)
        {
            case 1:
                if(curScore > PlayerPrefs.GetInt("level1_score"))
                {
                    PlayerPrefs.SetInt("level1_score", curScore);
                    if(curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level1_done", 1);
                        PlayerPrefs.SetInt("level1_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 100);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 20);
                        if (curScore > (passingScore*2))
                        {
                            PlayerPrefs.SetInt("level1_star2", 1);
                            if(curScore > (passingScore*3))
                                PlayerPrefs.SetInt("level1_star3", 1);
                        }
                    }
                    
                }
                break;
            case 2:
                if (curScore > PlayerPrefs.GetInt("level2_score"))
                {
                    PlayerPrefs.SetInt("level2_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level2_done", 1);
                        PlayerPrefs.SetInt("level2_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 130);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 30);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level2_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level2_star3", 1);
                        }
                    }

                }
                break;
            case 3:
                if (curScore > PlayerPrefs.GetInt("level3_score"))
                {
                    PlayerPrefs.SetInt("level3_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level3_done", 1);
                        PlayerPrefs.SetInt("level3_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 160);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 40);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level3_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level3_star3", 1);
                        }
                    }

                }
                break;
            case 4:
                if (curScore > PlayerPrefs.GetInt("level4_score"))
                {
                    PlayerPrefs.SetInt("level4_score", curScore);
                    if (curScore > passingScore)
                    {
                        if(PlayerPrefs.GetInt("level4_done") == 0)
                            PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + 5);
                        PlayerPrefs.SetInt("level4_done", 1);
                        PlayerPrefs.SetInt("level4_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 180);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 50);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level4_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level4_star3", 1);
                        }
                    }

                }
                break;
            case 5:
                if (curScore > PlayerPrefs.GetInt("level5_score"))
                {
                    PlayerPrefs.SetInt("level5_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level5_done", 1);
                        PlayerPrefs.SetInt("level5_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 180);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 50);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level5_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level5_star3", 1);
                        }
                    }

                }
                break;
            case 6:
                if (curScore > PlayerPrefs.GetInt("level6_score"))
                {
                    PlayerPrefs.SetInt("level6_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level6_done", 1);
                        PlayerPrefs.SetInt("level6_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 200);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 60);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level6_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level6_star3", 1);
                        }
                    }

                }
                break;
            case 7:
                if (curScore > PlayerPrefs.GetInt("level7_score"))
                {
                    PlayerPrefs.SetInt("level7_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level7_done", 1);
                        PlayerPrefs.SetInt("level7_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 220);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 70);

                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level7_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level7_star3", 1);
                        }
                    }

                }
                break;
            case 8:
                if (curScore > PlayerPrefs.GetInt("level8_score"))
                {
                    PlayerPrefs.SetInt("level8_score", curScore);
                    if (curScore > passingScore)
                    {
                        if (PlayerPrefs.GetInt("level8_done") == 0)
                            PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + 15);
                        PlayerPrefs.SetInt("level8_done", 1);
                        PlayerPrefs.SetInt("level8_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 240);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 80);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level8_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level8_star3", 1);
                        }
                    }

                }
                break;
            case 9:
                if (curScore > PlayerPrefs.GetInt("level9_score"))
                {
                    PlayerPrefs.SetInt("level9_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level9_done", 1);
                        PlayerPrefs.SetInt("level9_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 250);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 80);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level9_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level9_star3", 1);
                        }
                    }

                }
                break;
            case 10:
                if (curScore > PlayerPrefs.GetInt("level10_score"))
                {
                    PlayerPrefs.SetInt("level10_score", curScore);
                    if (curScore > passingScore)
                    {
                        PlayerPrefs.SetInt("level10_done", 1);
                        PlayerPrefs.SetInt("level10_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 270);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 90);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level10_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level10_star3", 1);
                        }
                    }

                }
                break;
            case 11:
                if (curScore > PlayerPrefs.GetInt("level11_score"))
                {
                    PlayerPrefs.SetInt("level11_score", curScore);
                    if (curScore > passingScore)
                    {
                        if (PlayerPrefs.GetInt("level11_done") == 0)
                            PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + 15);
                        PlayerPrefs.SetInt("level11_done", 1);
                        PlayerPrefs.SetInt("level11_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 290);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 100);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level11_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level11_star3", 1);
                        }
                    }

                }
                break;
            case 12:
                if (curScore > PlayerPrefs.GetInt("level12_score"))
                {
                    PlayerPrefs.SetInt("level12_score", curScore);
                    if (curScore > passingScore)
                    {
                        if (PlayerPrefs.GetInt("level12_done") == 0)
                            PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + 25);
                        PlayerPrefs.SetInt("level12_done", 1);
                        PlayerPrefs.SetInt("level12_star1", 1);
                        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 310);
                        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + 120);
                        if (curScore > (passingScore * 2))
                        {
                            PlayerPrefs.SetInt("level12_star2", 1);
                            if (curScore > (passingScore * 3))
                                PlayerPrefs.SetInt("level12_star3", 1);
                        }
                    }

                }
                break;
        }

    }

    void randomizer()
    {
        random = new int[count];
        for(int i = 0;i < count; i ++)
        {
            random[i] = Random.Range(1, range + 1);
            if (random[i] == 6)
                random[i] = 5;
        }
        
    }

    void rangeSetter()
    {
        if (PlayerPrefs.GetInt("pet5Unlocked") == 1)
        {
            PlayerPrefs.SetInt("range", 5);
        }
        else if (PlayerPrefs.GetInt("pet4Unlocked") == 1)
        {
            PlayerPrefs.SetInt("range", 4);
        }
        else if (PlayerPrefs.GetInt("pet3Unlocked") == 1)
        {
            PlayerPrefs.SetInt("range", 3);
        }
    }
    
    public void clicked1()
    {
        missed = false;
        if(canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 1)
            {
                score.text = (int.Parse(score.text) + Random.Range(250,325) + PlayerPrefs.GetInt("pet1_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_organic_collected",PlayerPrefs.GetInt("total_organic_collected") +1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                bg.GetComponent<RawImage>().color = new Color32(138, 255, 92, 255);
                Instantiate(correct);
            }
            else
            {
                bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
                Instantiate(error);
                if (int.Parse(life.text) > 1)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    Debug.Log("Incorrect match.");
                }
                else
                {
                    life.text = "0";
                    PlayerPrefs.SetInt("gameOn", 0);
                    ctr = count;
                    Debug.Log("You have no more lives.");
                }
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }
        
        
    }

    public void clicked2()
    {
        missed = false;
        if (canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 2)
            {
                score.text = (int.Parse(score.text) + Random.Range(250, 325) + PlayerPrefs.GetInt("pet2_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_plastic_collected", PlayerPrefs.GetInt("total_plastic_collected") + 1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                bg.GetComponent<RawImage>().color = new Color32(138, 255, 92, 255);
                Instantiate(correct);
            }
            else
            {
                bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
                Instantiate(error);
                if (int.Parse(life.text) > 1)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    Debug.Log("Incorrect match.");
                }
                else
                {
                    life.text = "0";
                    PlayerPrefs.SetInt("gameOn", 0);
                    ctr = count;
                    Debug.Log("You have no more lives.");
                }
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }

    }

    public void clicked3()
    {
        missed = false;
        if (canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 3)
            {
                score.text = (int.Parse(score.text) + Random.Range(265, 325) + PlayerPrefs.GetInt("pet3_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_hazard_collected", PlayerPrefs.GetInt("total_hazard_collected") + 1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                bg.GetComponent<RawImage>().color = new Color32(138, 255, 92, 255);
                Instantiate(correct);
            }
            else
            {
                bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
                Instantiate(error);
                if (int.Parse(life.text) > 1)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    Debug.Log("Incorrect match.");
                }
                else
                {
                    life.text = "0";
                    PlayerPrefs.SetInt("gameOn", 0);
                    ctr = count;
                    Debug.Log("You have no more lives.");
                }
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }

    }

    public void clicked4()
    {
        missed = false;
        if (canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 4)
            {
                score.text = (int.Parse(score.text) + Random.Range(280, 325) + PlayerPrefs.GetInt("pet4_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_glass_collected", PlayerPrefs.GetInt("total_glass_collected") + 1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                bg.GetComponent<RawImage>().color = new Color32(138, 255, 92, 255);
                Instantiate(correct);
            }
            else
            {
                bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
                Instantiate(error);
                if (int.Parse(life.text) > 1)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    Debug.Log("Incorrect match.");
                }
                else
                {
                    life.text = "0";
                    PlayerPrefs.SetInt("gameOn", 0);
                    ctr = count;
                    Debug.Log("You have no more lives.");
                }
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }

    }

    public void clicked5()
    {
        missed = false;
        if (canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 5)
            {
                score.text = (int.Parse(score.text) + Random.Range(300, 325) + PlayerPrefs.GetInt("pet5_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_metal_collected", PlayerPrefs.GetInt("total_metal_collected") + 1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                bg.GetComponent<RawImage>().color = new Color32(138, 255, 92, 255);
                Instantiate(correct);
            }
            else
            {
                bg.GetComponent<RawImage>().color = new Color32(255, 70, 70, 255);
                Instantiate(error);
                if (int.Parse(life.text) > 1)
                {
                    life.text = (int.Parse(life.text) - 1).ToString();
                    Debug.Log("Incorrect match.");
                }
                else
                {
                    life.text = "0";
                    PlayerPrefs.SetInt("gameOn", 0);
                    ctr = count;
                    Debug.Log("You have no more lives.");
                }
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }

    }
}
