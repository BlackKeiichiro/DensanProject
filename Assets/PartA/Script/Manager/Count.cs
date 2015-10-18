using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Count : MonoBehaviour {
	private Text time_ui;
	private Text escape_ui;
	private float dcount = 0.0f;
	private float esc_count = 30.0f;
	public int count;

	void Awake(){
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
		}
		escape_ui.text = string.Format("{0:N}\r\n",esc_count).ToString();
	}
}
