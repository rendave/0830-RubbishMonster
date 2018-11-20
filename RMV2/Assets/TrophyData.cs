using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrophyData : MonoBehaviour {

    public Text trophyCount;
    public Slider trophyC;

    public Text currentValue;
    public Text maxValue;

    public Text firstGoal;
    public Text secondGoal;
    public Text thirdGoal;

    public Text firstReward;
    public Text secondReward;
    public Text thirdReward;

    public Text exp;
    public Text gems;
    public Text coins;

    public Slider slider;

	// Use this for initialization
	void Start () {
        slider.value = CalculateExp();
        currentValue.text = PlayerPrefs.GetInt("trophy1_currentValue").ToString();
        Debug.Log("Current="+PlayerPrefs.GetInt("trophy1_currentValue").ToString());
        Debug.Log("Max=" + int.Parse(maxValue.text));
        
        Debug.Log(CalculateExp());
    }
	
	// Update is called once per frame
	void Update () {
        addExp();
    }

    void addExp()
    {
        if(PlayerPrefs.GetInt("trophy1_currentValue") < int.Parse(maxValue.text))
        {
            PlayerPrefs.SetInt("trophy1_currentValue", PlayerPrefs.GetInt("total_rubbish_collected"));

            if (PlayerPrefs.GetInt("trophy1_currentValue") >= int.Parse(maxValue.text))
            {
                if(PlayerPrefs.GetInt("trophy1_done") == 0)
                {
                    accomplish();
                    PlayerPrefs.SetInt("trophy1_done", 1);
                }
                PlayerPrefs.SetInt("trophy1_currentValue", int.Parse(maxValue.text));
            }
            else if ((PlayerPrefs.GetInt("trophy1_currentValue") >= int.Parse(thirdGoal.text)) && PlayerPrefs.GetInt("trophy1_goal3") == 0)
            {
                // gems
                PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(thirdReward.text));
                PlayerPrefs.SetInt("trophy1_goal3", 1);
            }
            else if ((PlayerPrefs.GetInt("trophy1_currentValue") >= int.Parse(secondGoal.text)) && PlayerPrefs.GetInt("trophy1_goal2") == 0)
            {
                // coins
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + int.Parse(secondReward.text));
                PlayerPrefs.SetInt("trophy1_goal2", 1);
            }
            else if ((PlayerPrefs.GetInt("trophy1_currentValue") >= int.Parse(firstGoal.text)) && PlayerPrefs.GetInt("trophy1_goal1") == 0)
            {
                // exp
                PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + int.Parse(firstReward.text));
                PlayerPrefs.SetInt("trophy1_goal1", 1);
            }

            slider.value = CalculateExp();
            currentValue.text = PlayerPrefs.GetInt("trophy1_currentValue").ToString();
        }
        
    }

    float CalculateExp()
    {
        return PlayerPrefs.GetInt("trophy1_currentValue") / float.Parse(maxValue.text);
    }

    void accomplish()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+int.Parse(coins.text));
        Debug.Log("Coins = "+PlayerPrefs.GetInt("coins"));
        PlayerPrefs.SetInt("gems", PlayerPrefs.GetInt("gems") + int.Parse(gems.text));
        Debug.Log("Gems = " + PlayerPrefs.GetInt("gems"));
        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + int.Parse(exp.text));
        Debug.Log("Exp = " + PlayerPrefs.GetInt("exp"));
        PlayerPrefs.SetInt("trophies", PlayerPrefs.GetInt("trophies") + 1);
        PlayerPrefs.Save();
        Debug.Log("Trophy accomplished!");
        trophyCount.text = PlayerPrefs.GetInt("trophies")+ "/3";
        trophyC.value = PlayerPrefs.GetInt("trophies") / 3f;
        PlayerPrefs.SetInt("trophy1_done", 1);
    }
    
}
