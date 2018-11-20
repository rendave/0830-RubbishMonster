using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Medals : MonoBehaviour {

    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;
    public GameObject bg5;


    // Use this for initialization
    void Start () {

        bg1.SetActive(false);
        bg2.SetActive(false);
        bg3.SetActive(false);
        bg4.SetActive(false);
        bg5.SetActive(false);

        switch (PlayerPrefs.GetString("medal"))
        {
            case "SWEEPER":
                bg1.SetActive(true);
                break;
            case "COLLECTOR":
                bg2.SetActive(true);
                break;
            case "LEADER":
                bg3.SetActive(true);
                break;
            case "MANAGER":
                bg4.SetActive(true);
                break;
            case "BOSS":
                bg5.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
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
}
