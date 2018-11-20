using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panelClaim : MonoBehaviour {

    public Button claim1;
    public Button claim2;
    public Button claim3;
    public Button claim4;
    public Button claim5;

    public Text coins1;
    public Text gems1;

    public Text coins3;
    public Text gems3;

    public Text coins4;
    public Text gems4;

    public Text coins5;
    public Text gems5;

    public RawImage bg1;
    public RawImage bg2;
    public RawImage bg3;
    public RawImage bg4;
    public RawImage bg5;

    public Text ctr1;
    public Text ctr2;
    public Text ctr3;
    public Text ctr4;
    public Text ctr5;

    public Slider sl1;
    public Slider sl2;
    public Slider sl3;
    public Slider sl4;
    public Slider sl5;

    // Use this for initialization
    void Start () {
        claim1.enabled = false;
        claim2.enabled = false;
        claim3.enabled = false;
        claim4.enabled = false;
        claim5.enabled = false;
        int l1 = setLevel("pet1_exp", 1);
        int l2 = setLevel("pet2_exp", 1);
        int l3 = setLevel("pet3_exp", 1);
        int l4 = setLevel("pet4_exp", 1);
        int l5 = setLevel("pet5_exp", 1);
        if(l1 >= 5)
        {
            ctr1.text = "5"+"/5";
            sl1.value = 1f;
        }
        else
        {
            ctr1.text = l1.ToString() + "/5";
            sl1.value = l1/5f;
        }
        if (l2 >= 5)
        {
            ctr2.text = "5" + "/5";
            sl2.value = 1f;
        }
        else
        {
            ctr2.text = l2.ToString() + "/5";
            sl2.value = l2 / 5f;
        }
        if (PlayerPrefs.GetInt("pet3Unlocked") == 1)
        {
            if (l3 >= 5)
            {
                ctr3.text = "5" + "/5";
                sl3.value = 1f;
            }
            else
            {
                ctr3.text = l3.ToString() + "/5";
                sl3.value = l3 / 5f;
            }
        }
        else
        {
            ctr3.text = "0" + "/5";
            sl3.value = 0f;
        }
        if (PlayerPrefs.GetInt("pet4Unlocked") == 1)
        {
            if (l4 >= 5)
            {
                ctr4.text = "5" + "/5";
                sl4.value = 1f;
            }
            else
            {
                ctr4.text = l4.ToString() + "/5";
                sl4.value = l4 / 5f;
            }
        }
        else
        {
            ctr4.text = "0" + "/5";
            sl4.value = 0f;
        }
        if (PlayerPrefs.GetInt("pet5Unlocked") == 1)
        {
            if (l5 >= 5)
            {
                ctr5.text = "5" + "/5";
                sl5.value = 1f;
            }
            else
            {
                ctr5.text = l5.ToString() + "/5";
                sl5.value = l5 / 5f;
            }
        }
        else
        {
            ctr5.text = "0" + "/5";
            sl5.value = 0f;
        }
        

        if (l1 >= 5)
        {
            if (PlayerPrefs.GetInt("claim1") == 1)
            {
                claim1.enabled = false;
                bg1.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
            }
            else
            {
                claim1.enabled = true;
            }
        }
        if (l2 >= 5)
        {
            if (PlayerPrefs.GetInt("claim2") == 1)
            {
                claim2.enabled = false;
                bg2.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
            }
            else
            {
                claim2.enabled = true;
            }
        }
        if (l3 >= 5)
        {
            if (PlayerPrefs.GetInt("claim3") == 1)
            {
                claim3.enabled = false;
                bg3.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
            }
            else
            {
                claim3.enabled = true;
            }
        }
        if (l4 >= 5)
        {
            if (PlayerPrefs.GetInt("claim4") == 1)
            {
                claim4.enabled = false;
                bg4.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
            }
            else
            {
                claim2.enabled = true;
            }
        }
        if (l5 >= 5)
        {
            if (PlayerPrefs.GetInt("claim5") == 1)
            {
                claim5.enabled = false;
                bg5.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
            }
            else
            {
                claim5.enabled = true;
            }
        }
    }
    

    int setLevel(string pet, int petnum)
    {
        int e = PlayerPrefs.GetInt(pet);
        int level = 0;
        if (e > 1000)
        {
            level = 10;
        }
        else if (e > 800)
        {
            level = 9;
        }
        else if (e > 700)
        {
            level = 8;
        }
        else if (e > 600)
        {
            level = 7;
        }
        else if (e > 500)
        {
            level = 6;
        }
        else if (e > 400)
        {
            level = 5;
        }
        else if (e > 300)
        {
            level = 4;
        }
        else if (e > 200)
        {
            level = 3;
        }
        else if (e > 100)
        {
            level = 2;
        }
        else
        {
            level = 1;
        }
        return level;
    }

    // Update is called once per frame
    void Update () {
        if (PlayerPrefs.GetInt("claim1") == 1)
        {
            claim1.enabled = false;
            bg1.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
        }
        if (PlayerPrefs.GetInt("claim2") == 1)
        {
            claim2.enabled = false;
            bg2.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
        }
        if (PlayerPrefs.GetInt("claim3") == 1 && PlayerPrefs.GetInt("pet3Unlocked") == 1)
        {
            claim3.enabled = false;
            bg3.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
        }
        if (PlayerPrefs.GetInt("claim4") == 1 && PlayerPrefs.GetInt("pet4Unlocked") == 1)
        {
            claim4.enabled = false;
            bg4.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
        }
        if (PlayerPrefs.GetInt("claim5") == 1 && PlayerPrefs.GetInt("pet5Unlocked") == 1)
        {
            claim5.enabled = false;
            bg5.GetComponent<RawImage>().color = new Color32(255, 227, 0, 255);
        }
    }

    public void clicked1()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+int.Parse(coins1.text));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems1.text));
        PlayerPrefs.SetInt("claim1", 1);
    }

    public void clicked2()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + int.Parse(coins1.text));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems1.text));
        PlayerPrefs.SetInt("claim2", 1);
    }

    public void clicked3()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + int.Parse(coins3.text));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems3.text));
        PlayerPrefs.SetInt("claim3", 1);
    }
    public void clicked4()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + int.Parse(coins4.text));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems4.text));
        PlayerPrefs.SetInt("claim4", 1);
    }
    public void clicked5()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + int.Parse(coins5.text));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems5.text));
        PlayerPrefs.SetInt("claim5", 1);
    }

    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
}
