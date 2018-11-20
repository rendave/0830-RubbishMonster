using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    int range;


    public int ufoSpeed;
    public float Timer = 2;
    public GameObject type1;
    public GameObject type2;
    public GameObject type3;
    public GameObject type4;
    public GameObject type5;
    GameObject objectClone;
    int ran;

    bool hasAppeared = true;

    // Use this for initialization
    void Start () {
        //Physics2D.gravity = new Vector3(0f, 10f, 0f);
        Physics2D.gravity = new Vector3(-100f,0f,0f);
        /////
        rangeSetter();
        range = PlayerPrefs.GetInt("range");
        Debug.Log(range);
    }
	
    void rangeSetter()
    {
        //PlayerPrefs.SetInt("pet5Unlocked", 1);
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
    
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("Object has been destroyed.");
    }
    
    // Update is called once per frame
    void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            randomizer();
            // Random.Range(-9, 9)
            switch(ran)
            {
                case 1:
                    objectClone = Instantiate(type1, new Vector3(2000f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                    PlayerPrefs.SetInt("current_type", 1);
                    break;
                case 2:
                    objectClone = Instantiate(type2, new Vector3(2000f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                    PlayerPrefs.SetInt("current_type", 2);
                    break;
                case 3:
                    objectClone = Instantiate(type3, new Vector3(2000f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(100f, 100f, 0f);
                    PlayerPrefs.SetInt("current_type", 3);
                    break;
                case 4:
                    objectClone = Instantiate(type4, new Vector3(2000f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(100f, 100f, 0f);
                    PlayerPrefs.SetInt("current_type", 4);
                    break;
                case 5:
                    objectClone = Instantiate(type5, new Vector3(2000f, 5f, 0f), transform.rotation) as GameObject;
                    objectClone.transform.localScale = new Vector3(400f, 400f, 0f);
                    PlayerPrefs.SetInt("current_type", 5);
                    break;
            }
            Debug.Log(Timer);
            Timer = 2f;
            Debug.Log(PlayerPrefs.GetInt("current_type"));
        }
    }

    void randomizer()
    {
        ran = Random.Range(1, range+1);
        if (ran == 6)
            ran = 5;
    }
}
