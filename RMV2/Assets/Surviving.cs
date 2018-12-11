using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Surviving : MonoBehaviour {

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

    public Text score;

    public GameObject start;
    public GameObject end;
    public Text imageCount;
    public Text endScore;
    public Text highscore;

    public GameObject correct;
    public GameObject endmusic;

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
    bool exist = true;


    // Use this for initialization
    void Start () {
        end.SetActive(false);
        exist = true;
    }

    public void ends()
    {
        SceneManager.LoadScene("PLAYSURVIVAL");
    }

    public void startClicked()
    {
        highscore.text = PlayerPrefs.GetInt("survival_score").ToString();
        count = PlayerPrefs.GetInt("survival_count");
        PlayerPrefs.SetInt("gameOn", 1);
        exist = false;
        score.text = "0";
        rangeSetter();
        range = PlayerPrefs.GetInt("range");
        //count = PlayerPrefs.GetInt("survival_count");
        imageCount.text = count.ToString();
        speed = PlayerPrefs.GetInt("survival_time");
        if (speed == 4)
            grav = -100f;
        else if (speed == 3)
            grav = -200f;
        else if (speed == 2)
            grav = -300f;
        else if (speed == 1)
            grav = -400f;
        Physics2D.gravity = new Vector3(grav, 0f, 0f);
        randomizer();
        Destroy(start);
    }

    void randomizer()
    {
        random = new int[count];
        for (int i = 0; i < count; i++)
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

    
    // Update is called once per frame
    void Update () {
        if (!exist)
        {
            Debug.Log("EXIST DAW");
            if (ctr < count && PlayerPrefs.GetInt("gameOn") == 1)
            {
                canclick = true;
                int z = Random.Range(0, 5);

                if ((ctr > 0) && missed)
                {
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
                        else if (z == 1)
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
                        else if (z == 1)
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
                        else if (z == 1)
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
                Debug.Log("Happens");
                exist = true;
                ctr++;
                imageCount.text = (int.Parse(imageCount.text) + 1).ToString();
            }
            else
            {
                Debug.Log("MEOWK");
                PlayerPrefs.SetInt("gameOn", 0);
            }
        }

        /*Vector3 screenPoint = Camera.main.WorldToViewportPoint(objectClone.transform.position);
        bool onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
        
        if (!onScreen)
        {
            Destroy(objectClone);
            exist = false;
            PlayerPrefs.SetInt("gameOn", 0);
        }
        */

        // end of game here
        if (PlayerPrefs.GetInt("gameOn") == 0)
        {
            if(int.Parse(score.text) > PlayerPrefs.GetInt("survival_score"))
                PlayerPrefs.SetInt("survival_score", int.Parse(score.text));
            Instantiate(endmusic);
            Debug.Log("THIS IS HAPPENINGZZZ");
            end.SetActive(true);
            endScore.text = score.text;
        }
    }

    public void clicked1()
    {
        missed = false;
        if (canclick)
        {
            if (PlayerPrefs.GetInt("current_type") == 1)
            {
                score.text = (int.Parse(score.text) + Random.Range(250, 325) + PlayerPrefs.GetInt("pet1_exp") / 100 * 25).ToString();
                PlayerPrefs.SetInt("total_organic_collected", PlayerPrefs.GetInt("total_organic_collected") + 1);
                PlayerPrefs.SetInt("total_rubbish_collected", PlayerPrefs.GetInt("total_rubbish_collected") + 1);
                Debug.Log("Correct match.");
                Instantiate(correct);
                Debug.Log("This has meowk.");
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
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
                Instantiate(correct);
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
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
                Instantiate(correct);
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
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
                Instantiate(correct);
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
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
                Instantiate(correct);
            }
            else
            {
                PlayerPrefs.SetInt("gameOn", 0);
            }
            canclick = false;
            Destroy(objectClone);
            exist = false;
        }

    }
}
