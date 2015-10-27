using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Count : MonoBehaviour {
	private Text time_ui;
	private Text escape_ui;
	private float dcount = 0.0f;
	private float esc_count = 30.0f;
	private ItemManager manager;
	private int stage;
	public int count;

	void Awake(){
		dcount = PlayerPrefs.GetFloat("Count");
		stage = PlayerPrefs.GetInt("StageNumber");
		stage++;
		manager = GameObject.Find("Manager").GetComponent<ItemManager>();
		time_ui = GameObject.Find("Canvas/TimePanel/Time").GetComponent<Text>();
		escape_ui = GameObject.Find("Canvas/EscapePanel/EscapeTime").GetComponent<Text>();
	}
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		dcount += Time.deltaTime;
		esc_count -= Time.deltaTime;
		count = Convert.ToInt32 (dcount);
		time_ui.text = string.Format("{0:N}\r\n",dcount).ToString();
		if(esc_count <= 0.00f){
			esc_count = 0.00f;
			PlayerPrefs.SetFloat("Count",esc_count);
			PlayerPrefs.SetInt("StageNumber",stage);
			PlayerPrefs.SetInt("Grade",manager.GetGrage());
			Application.LoadLevel("");
		}
		escape_ui.text = string.Format("{0:N}\r\n",esc_count).ToString();
	}
}
