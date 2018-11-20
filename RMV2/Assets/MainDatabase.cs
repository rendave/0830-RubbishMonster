using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDatabase : MonoBehaviour {

    bool firstTime;

    // Use this for initialization
    void Start () {
        firstTime = PlayerPrefs.GetInt("firstTime") == 0 ? true : false;
        if (firstTime)
        {
            // pets
            PlayerPrefs.SetString("pet1", "Didee");
            PlayerPrefs.SetString("pet2", "Toby");
            PlayerPrefs.SetString("pet3", "Mikey");
            PlayerPrefs.SetString("pet4", "Libi");
            PlayerPrefs.SetString("pet5", "Gaji");

            PlayerPrefs.SetInt("pet1_exp", 0);
            PlayerPrefs.SetInt("pet2_exp", 0);
            PlayerPrefs.SetInt("pet3_exp", 0);
            PlayerPrefs.SetInt("pet4_exp", 0);
            PlayerPrefs.SetInt("pet5_exp", 0);

            PlayerPrefs.SetInt("pet3Unlocked", 0);
            PlayerPrefs.SetInt("pet4Unlocked", 0);
            PlayerPrefs.SetInt("pet5Unlocked", 0);

            // medals
            PlayerPrefs.SetString("medal", "SWEEPER");

            // menu coins, gems
            PlayerPrefs.SetInt("coins", 100);
            PlayerPrefs.SetInt("gems", 0);
            PlayerPrefs.SetInt("exp", 0);
            PlayerPrefs.SetInt("firstTime", 1);
            PlayerPrefs.SetInt("tutorial", 1);

            // trophies
            PlayerPrefs.SetInt("trophies", 0);
            // trophy 1
            PlayerPrefs.SetInt("trophy1_currentValue", 0);
            PlayerPrefs.SetInt("trophy1_goal1", 0);
            PlayerPrefs.SetInt("trophy1_goal2", 0);
            PlayerPrefs.SetInt("trophy1_goal3", 0);
            PlayerPrefs.SetInt("trophy1_done", 0);
            // trophy 2
            PlayerPrefs.SetInt("trophy2_currentValue", 0);
            PlayerPrefs.SetInt("trophy2_goal1", 0);
            PlayerPrefs.SetInt("trophy2_goal2", 0);
            PlayerPrefs.SetInt("trophy2_goal3", 0);
            PlayerPrefs.SetInt("trophy2_done", 0);
            // trophy 3
            PlayerPrefs.SetInt("trophy3_currentValue", 0);
            PlayerPrefs.SetInt("trophy3_goal1", 0);
            PlayerPrefs.SetInt("trophy3_goal2", 0);
            PlayerPrefs.SetInt("trophy3_goal3", 0);
            PlayerPrefs.SetInt("trophy3_done", 0);

            // levels
            PlayerPrefs.SetInt("current_level", 0);
            PlayerPrefs.SetInt("current_score", 0);
            PlayerPrefs.SetInt("current_star1", 0);
            PlayerPrefs.SetInt("current_star2", 0);
            PlayerPrefs.SetInt("current_star3", 0);
            
            // level1
            PlayerPrefs.SetInt("level1_done", 0);
            PlayerPrefs.SetInt("level1_score", 0);
            PlayerPrefs.SetInt("level1_star1", 0);
            PlayerPrefs.SetInt("level1_star2", 0);
            PlayerPrefs.SetInt("level1_star3", 0);
            PlayerPrefs.SetInt("level1_count", 8);
            PlayerPrefs.SetInt("level1_time", 4);
            // level2
            PlayerPrefs.SetInt("level2_done", 0);
            PlayerPrefs.SetInt("level2_score", 0);
            PlayerPrefs.SetInt("level2_star1", 0);
            PlayerPrefs.SetInt("level2_star2", 0);
            PlayerPrefs.SetInt("level2_star3", 0);
            PlayerPrefs.SetInt("level2_count", 12);
            PlayerPrefs.SetInt("level2_time", 4);
            // level3
            PlayerPrefs.SetInt("level3_done", 0);
            PlayerPrefs.SetInt("level3_score", 0);
            PlayerPrefs.SetInt("level3_star1", 0);
            PlayerPrefs.SetInt("level3_star2", 0);
            PlayerPrefs.SetInt("level3_star3", 0);
            PlayerPrefs.SetInt("level3_count", 16);
            PlayerPrefs.SetInt("level3_time", 4);
            // level4
            PlayerPrefs.SetInt("level4_done", 0);
            PlayerPrefs.SetInt("level4_score", 0);
            PlayerPrefs.SetInt("level4_star1", 0);
            PlayerPrefs.SetInt("level4_star2", 0);
            PlayerPrefs.SetInt("level4_star3", 0);
            PlayerPrefs.SetInt("level4_count", 8);
            PlayerPrefs.SetInt("level4_time", 3);
            // level5
            PlayerPrefs.SetInt("level5_done", 0);
            PlayerPrefs.SetInt("level5_score", 0);
            PlayerPrefs.SetInt("level5_star1", 0);
            PlayerPrefs.SetInt("level5_star2", 0);
            PlayerPrefs.SetInt("level5_star3", 0);
            PlayerPrefs.SetInt("level5_count", 12);
            PlayerPrefs.SetInt("level5_time", 3);
            // level6
            PlayerPrefs.SetInt("level6_done", 0);
            PlayerPrefs.SetInt("level6_score", 0);
            PlayerPrefs.SetInt("level6_star1", 0);
            PlayerPrefs.SetInt("level6_star2", 0);
            PlayerPrefs.SetInt("level6_star3", 0);
            PlayerPrefs.SetInt("level6_count", 16);
            PlayerPrefs.SetInt("level6_time", 3);
            // level7
            PlayerPrefs.SetInt("level7_done", 0);
            PlayerPrefs.SetInt("level7_score", 0);
            PlayerPrefs.SetInt("level7_star1", 0);
            PlayerPrefs.SetInt("level7_star2", 0);
            PlayerPrefs.SetInt("level7_star3", 0);
            PlayerPrefs.SetInt("level7_count", 8);
            PlayerPrefs.SetInt("level7_time", 2);
            // level8
            PlayerPrefs.SetInt("level8_done", 0);
            PlayerPrefs.SetInt("level8_score", 0);
            PlayerPrefs.SetInt("level8_star1", 0);
            PlayerPrefs.SetInt("level8_star2", 0);
            PlayerPrefs.SetInt("level8_star3", 0);
            PlayerPrefs.SetInt("level8_count", 12);
            PlayerPrefs.SetInt("level8_time", 2);
            // level9
            PlayerPrefs.SetInt("level9_done", 0);
            PlayerPrefs.SetInt("level9_score", 0);
            PlayerPrefs.SetInt("level9_star1", 0);
            PlayerPrefs.SetInt("level9_star2", 0);
            PlayerPrefs.SetInt("level9_star3", 0);
            PlayerPrefs.SetInt("level9_count", 16);
            PlayerPrefs.SetInt("level9_time", 2);
            // level10
            PlayerPrefs.SetInt("level10_done", 0);
            PlayerPrefs.SetInt("level10_score", 0);
            PlayerPrefs.SetInt("level10_star1", 0);
            PlayerPrefs.SetInt("level10_star2", 0);
            PlayerPrefs.SetInt("level10_star3", 0);
            PlayerPrefs.SetInt("level10_count", 8);
            PlayerPrefs.SetInt("level10_time", 1);
            // level11
            PlayerPrefs.SetInt("level11_done", 0);
            PlayerPrefs.SetInt("level11_score", 0);
            PlayerPrefs.SetInt("level11_star1", 0);
            PlayerPrefs.SetInt("level11_star2", 0);
            PlayerPrefs.SetInt("level11_star3", 0);
            PlayerPrefs.SetInt("level11_count", 12);
            PlayerPrefs.SetInt("level11_time", 1);
            // level12
            PlayerPrefs.SetInt("level12_done", 0);
            PlayerPrefs.SetInt("level12_score", 0);
            PlayerPrefs.SetInt("level12_star1", 0);
            PlayerPrefs.SetInt("level12_star2", 0);
            PlayerPrefs.SetInt("level12_star3", 0);
            PlayerPrefs.SetInt("level12_count", 16);
            PlayerPrefs.SetInt("level12_time", 1);

            // survival
            PlayerPrefs.SetInt("survival_score", 0);
            PlayerPrefs.SetInt("survival_count", 5);
            PlayerPrefs.SetInt("survival_time", 4);

            // gameplay
            PlayerPrefs.SetInt("pet1_active",1);
            PlayerPrefs.SetInt("pet2_active", 1);
            PlayerPrefs.SetInt("pet3_active", 0);
            PlayerPrefs.SetInt("pet4_active", 0);
            PlayerPrefs.SetInt("pet5_active", 0);

            PlayerPrefs.SetInt("current_type",0);
            PlayerPrefs.SetInt("current_level_count",0);
            PlayerPrefs.SetInt("current_level_time", 0);
            PlayerPrefs.SetInt("gameOn", 1);
            PlayerPrefs.SetInt("range", 2);

            // player stats
            PlayerPrefs.SetInt("total_organic_collected",0);
            PlayerPrefs.SetInt("total_plastic_collected", 0);
            PlayerPrefs.SetInt("total_hazard_collected", 0);
            PlayerPrefs.SetInt("total_glass_collected", 0);
            PlayerPrefs.SetInt("total_metal_collected", 0);
            PlayerPrefs.SetInt("total_rubbish_collected", 0);
            PlayerPrefs.SetInt("total_stars_collected", 0);

            // messages
            PlayerPrefs.SetString("m1", "Improve your score and gain more stars by leveling up your pets.");
            PlayerPrefs.SetString("m2", "The higher your pets' levels are, the more score you get from your games!");
            PlayerPrefs.SetString("m3", "Gain Formula points and Special Formula points by gaining trophies.");
            PlayerPrefs.SetString("m4", "The average person generates over 4 pounds of trash every day and about 1.5 tons of solid waste per year.");
            PlayerPrefs.SetString("m5", "We generate 21.5 million tons of food waste each year. If we composted that food, it would reduce the same amount of greenhouse gas as taking 2 million cars off the road.");
            PlayerPrefs.SetString("m6", "The Philippines is the world's 3rd biggest dumper of plastics in the ocean.");
            PlayerPrefs.SetString("m7", "A single resident produces an average of 0.7 kilogram of waste a day, about “130 percent higher” than the global average of 0.3 kg per person per day");

            // claim_special_mission
            PlayerPrefs.SetInt("claim1", 0);
            PlayerPrefs.SetInt("claim2", 0);
            PlayerPrefs.SetInt("claim3", 0);
            PlayerPrefs.SetInt("claim4", 0);
            PlayerPrefs.SetInt("claim5", 0);

            PlayerPrefs.SetString("mess0", "WELCOME TO RUBBISH MONSTERS!");
            PlayerPrefs.SetString("mess1", "The developers' goal of creating the app is to educate and teach you how to segregate rubbish.");
            PlayerPrefs.SetString("mess2", "There are 5 types of rubbish in this discussion. Organic, Plastic, Hazardous, Glass, and Metal.");
            PlayerPrefs.SetString("mess3", "You will be taking care of pets by feeding them with the only rubbish they eat.");
            PlayerPrefs.SetString("mess4", "Feed them through playing levels found on the map. You can check them in the Pets.");
            PlayerPrefs.SetString("mess5", "You can also level your pets up by giving them formula 1 and special formula.");
            PlayerPrefs.SetString("mess6", "You can gain formula 1 and special formula by completing levels, missions, and trophies.");
            PlayerPrefs.SetString("mess7", "See your performance and know the number or rubbish you collected and fed in the Statistics.");
            PlayerPrefs.SetString("mess8", "Since you're a rookie, you currently acquire the SWEEPER medal. Check them out in the Medals.");
            PlayerPrefs.SetString("mess9", "Improve your medal by gaining experience through playing levels and earn new pets!");
            PlayerPrefs.SetString("mess10", "I think you're ready so I'll leave Didee and Toby in your care. You can rename them in Pets if you wish.");
            PlayerPrefs.SetInt("messNum",0);

            // daily mission
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
