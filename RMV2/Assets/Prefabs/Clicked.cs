using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour {

    public int type;
    
    public void cliked1()
    {
        PlayerPrefs.SetInt("matched", 0);
        if (type == PlayerPrefs.GetInt("current_type"))
        {
            PlayerPrefs.SetInt("matched",1);
        }
    }
    
}
