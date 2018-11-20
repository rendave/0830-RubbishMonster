using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Database : MonoBehaviour {

    public Text pet1;
    public Text pet2;
    public Text pet3;
    public Text pet4;
    public Text pet5;
    public Text coins;
    public Text gems;

    public GameObject pett3;
    public GameObject pett4;
    public GameObject pett5;

    public Text pet1lvl;
    public Text pet2lvl;
    public Text pet3lvl;
    public Text pet4lvl;
    public Text pet5lvl;

    public Slider pet1bar;
    public Slider pet2bar;
    public Slider pet3bar;
    public Slider pet4bar;
    public Slider pet5bar;


    public void feedCoin(string pet_exp)
    {
        int e = PlayerPrefs.GetInt(pet_exp);
        int coin = PlayerPrefs.GetInt("coins");
        int cost = 100;
        if(coin >= cost && e < 1000)
        {
            PlayerPrefs.SetInt(pet_exp, PlayerPrefs.GetInt(pet_exp) + Random.Range(5, 8));
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100);
            /*if (EditorUtility.DisplayDialog("Feed formula one.", "Feeding successful. Feeding formula costs you 100 formula points.", "Yes", "No"))
                print("Pressed Yes.");
            else
                print("Pressed No.");*/
            Debug.Log(pet_exp + " = " + PlayerPrefs.GetInt(pet_exp));
        }
    }

    public void feedGem(string pet_exp)
    {
        int e = PlayerPrefs.GetInt(pet_exp);
        int gem = PlayerPrefs.GetInt("gems");
        int cost = 1;
        if (gem >= cost && e < 1000)
        {
            PlayerPrefs.SetInt(pet_exp, PlayerPrefs.GetInt(pet_exp) + Random.Range(20, 30));
            PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") - 1);
            Debug.Log(pet_exp + " = " + PlayerPrefs.GetInt(pet_exp));
        }

    }

    // Use this for initialization
    void Start () {
        coins.text = PlayerPrefs.GetInt("coins").ToString();
        gems.text = PlayerPrefs.GetInt("gems").ToString();
        pet1.text = PlayerPrefs.GetString("pet1");
        pet2.text = PlayerPrefs.GetString("pet2");
        pett3.SetActive(false);
        pett4.SetActive(false);
        pett5.SetActive(false);
        if (PlayerPrefs.GetInt("pet3Unlocked") == 1)
        {
            pett3.SetActive(true);
            pet3.text = PlayerPrefs.GetString("pet3");
        }
        if (PlayerPrefs.GetInt("pet4Unlocked") == 1)
        {
            pett4.SetActive(true);
            pet4.text = PlayerPrefs.GetString("pet4");
        }
        if (PlayerPrefs.GetInt("pet5Unlocked") == 1)
        {
            pett5.SetActive(true);
            pet5.text = PlayerPrefs.GetString("pet5");
        }

        setLevel("pet1_exp", 1);
        setLevel("pet2_exp", 2);
        setLevel("pet3_exp", 3);
        setLevel("pet4_exp", 4);
        setLevel("pet5_exp", 5);
    }

    void setLevel(string pet, int petnum)
    {
        int e = PlayerPrefs.GetInt(pet);
        if (e > 1000)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "10";
                    pet1bar.value = 1f;
                    break;
                case 2:
                    pet2lvl.text = "10";
                    pet2bar.value = 1f;
                    break;
                case 3:
                    pet3lvl.text = "10";
                    pet3bar.value = 1f;
                    break;
                case 4:
                    pet4lvl.text = "10";
                    pet4bar.value = 1f;
                    break;
                case 5:
                    pet5lvl.text = "10";
                    pet5bar.value = 1f;
                    break;
            }
        }
        else if (e > 800)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "9";
                    pet1bar.value = (200 - (1000f - e)) / 200;
                    break;
                case 2:
                    pet2lvl.text = "9";
                    pet2bar.value = (200 - (1000f - e)) / 200;
                    break;
                case 3:
                    pet3lvl.text = "9";
                    pet3bar.value = (200 - (1000f - e)) / 200;
                    break;
                case 4:
                    pet4lvl.text = "9";
                    pet4bar.value = (200 - (1000f - e)) / 200;
                    break;
                case 5:
                    pet5lvl.text = "9";
                    pet5bar.value = (200 - (1000f - e)) / 200;
                    break;
            }
        }
        else if (e > 700)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "8";
                    pet1bar.value = 1 - (800f - e) / (800f/8);
                    break;
                case 2:
                    pet2lvl.text = "8";
                    pet2bar.value = 1 - (800f - e) / (800f / 8);
                    break;
                case 3:
                    pet3lvl.text = "8";
                    pet3bar.value = 1 - (800f - e) / (800f / 8);
                    break;
                case 4:
                    pet4lvl.text = "8";
                    pet4bar.value = 1 - (800f - e) / (800f / 8);
                    break;
                case 5:
                    pet5lvl.text = "8";
                    pet5bar.value = 1 - (800f - e) / (800f / 8);
                    break;
            }
        }
        else if (e > 600)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "7";
                    pet1bar.value = 1 - (700f - e) / (700f / 7);
                    break;
                case 2:
                    pet2lvl.text = "7";
                    pet2bar.value = 1 - (700f - e) / (700f / 7);
                    break;
                case 3:
                    pet3lvl.text = "7";
                    pet3bar.value = 1 - (700f - e) / (700f / 7);
                    break;
                case 4:
                    pet4lvl.text = "7";
                    pet4bar.value = 1 - (700f - e) / (700f / 7);
                    break;
                case 5:
                    pet5lvl.text = "7";
                    pet5bar.value = 1 - (700f - e) / (700f / 7);
                    break;
            }
        }
        else if (e > 500)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "6";
                    pet1bar.value = 1 - (600f - e) / (600f / 6);
                    break;
                case 2:
                    pet2lvl.text = "6";
                    pet2bar.value = 1 - (600f - e) / (600f / 6);
                    break;
                case 3:
                    pet3lvl.text = "6";
                    pet3bar.value = 1 - (600f - e) / (600f / 6);
                    break;
                case 4:
                    pet4lvl.text = "6";
                    pet4bar.value = 1 - (600f - e) / (600f / 6);
                    break;
                case 5:
                    pet5lvl.text = "6";
                    pet5bar.value = 1 - (600f - e) / (600f / 6);
                    break;
            }
        }
        else if (e > 400)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "5";
                    pet1bar.value = 1 - (500f - e) / (500f / 5);
                    break;
                case 2:
                    pet2lvl.text = "5";
                    pet2bar.value = 1 - (500f - e) / (500f / 5);
                    break;
                case 3:
                    pet3lvl.text = "5";
                    pet3bar.value = 1 - (500f - e) / (500f / 5);
                    break;
                case 4:
                    pet4lvl.text = "5";
                    pet4bar.value = 1 - (500f - e) / (500f / 5);
                    break;
                case 5:
                    pet5lvl.text = "5";
                    pet5bar.value = 1 - (500f - e) / (500f / 5);
                    break;
            }
        }
        else if (e > 300)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "4";
                    pet1bar.value = 1 - (400f - e) / (400f / 4);
                    break;
                case 2:
                    pet2lvl.text = "4";
                    pet2bar.value = 1 - (400f - e) / (400f / 4);
                    break;
                case 3:
                    pet3lvl.text = "4";
                    pet3bar.value = 1 - (400f - e) / (400f / 4);
                    break;
                case 4:
                    pet4lvl.text = "4";
                    pet4bar.value = 1 - (400f - e) / (400f / 4);
                    break;
                case 5:
                    pet5lvl.text = "4";
                    pet5bar.value = 1 - (400f - e) / (400f / 4);
                    break;
            }
        }
        else if (e > 200)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "3";
                    pet1bar.value = 1 - (300f - e) / (300f / 3);
                    break;
                case 2:
                    pet2lvl.text = "3";
                    pet2bar.value = 1 - (300f - e) / (300f / 3);
                    break;
                case 3:
                    pet3lvl.text = "3";
                    pet3bar.value = 1 - (300f - e) / (300f / 3);
                    break;
                case 4:
                    pet4lvl.text = "3";
                    pet4bar.value = 1 - (300f - e) / (300f / 3);
                    break;
                case 5:
                    pet5lvl.text = "3";
                    pet5bar.value = 1 - (300f - e) / (300f / 3);
                    break;
            }
        }
        else if (e > 100)
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "2";
                    pet1bar.value = 1 - (200f - e) / (200f / 2);
                    break;
                case 2:
                    pet2lvl.text = "2";
                    pet2bar.value = 1 - (200f - e) / (200f / 2);
                    break;
                case 3:
                    pet3lvl.text = "2";
                    pet3bar.value = 1 - (200f - e) / (200f / 2);
                    break;
                case 4:
                    pet4lvl.text = "2";
                    pet4bar.value = 1 - (200f - e) / (200f / 2);
                    break;
                case 5:
                    pet5lvl.text = "2";
                    pet5bar.value = 1 - (200f - e) / (200f / 2);
                    break;
            }
        }
        else
        {
            switch (petnum)
            {
                case 1:
                    pet1lvl.text = "1";
                    pet1bar.value = 1 - (100f - e) / (100f / 1);
                    break;
                case 2:
                    pet2lvl.text = "1";
                    pet2bar.value = 1 - (100f - e) / (100f / 1);
                    break;
                case 3:
                    pet3lvl.text = "1";
                    pet3bar.value = 1 - (100f - e) / (100f / 1);
                    break;
                case 4:
                    pet4lvl.text = "1";
                    pet4bar.value = 1 - (100f - e) / (100f / 1);
                    break;
                case 5:
                    pet5lvl.text = "1";
                    pet5bar.value = 1 - (100f - e) / (100f / 1);
                    break;
            }
        }
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
        coins.text = PlayerPrefs.GetInt("coins").ToString();
        gems.text = PlayerPrefs.GetInt("gems").ToString();
        setLevel("pet1_exp", 1);
        setLevel("pet2_exp", 2);
        setLevel("pet3_exp", 3);
        setLevel("pet4_exp", 4);
        setLevel("pet5_exp", 5);
    }

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
    
}
