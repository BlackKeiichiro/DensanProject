using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemManager : MonoBehaviour {
    private Image gauge;
    private Text level_ui;
    private bool gauge_switch = false;
    private float keep_gage = 0;
    private float one_gauge = 0.1f;
    private int weapon_level = 0;
    private int limit_gauge = 3;

	void Start () {
        gauge = GameObject.Find("Canvas/Weapon/Gauge").GetComponent<Image>();
        level_ui = GameObject.Find("Canvas/Weapon/Level").GetComponent<Text>();
	}
	
	void Update () {
        if (gauge_switch && gauge.fillAmount - keep_gage < one_gauge && weapon_level < limit_gauge)
        {
            gauge.fillAmount += 0.01f;
            if (gauge.fillAmount == 1)
            {
                gauge_switch = false;
                weapon_level++;
                gauge.fillAmount = 0;
                keep_gage = 0;
                level_ui.text = LevelFactory(weapon_level);
            }
        }
	}

    

    public void OnTriggerCall() {
        gauge_switch = true;
        keep_gage = gauge.fillAmount;
    }

    private string LevelFactory(int level)
    {
        string kanji_level = level_ui.text;
        switch (level)
        {
            case 0:
                kanji_level = "零";
                break;
            case 1:
                kanji_level = "壱";
                break;
            case 2:
                kanji_level = "弐";
                break;
            case 3:
                kanji_level = "参";
                break; 
        }
        return kanji_level;
    }
}
