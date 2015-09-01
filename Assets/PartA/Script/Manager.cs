﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;


public class Manager : MonoBehaviour {
	public int count = 0;
	public float comp = 0.0f;
	public float spawantime = 0;
	public float speed = 50;
	public float root = 1f;
	public float fall_speed = 0.35f;
	public bool moveflag = false;
	float interval = 1.0f;
	public int partswitch;
	public float _magnitude;
	public int[,,] patternlist;
	private Text uitext;
	private GameObject timetext;
	
	void Awake(){
		uitext = GameObject.Find("Time").GetComponent<Text>();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		comp += Time.deltaTime;
		count = Convert.ToInt32 (comp);
		
		if(spawantime < Time.timeSinceLevelLoad){
			uitext.text = "Time:"+count.ToString();
			spawantime = Time.timeSinceLevelLoad + interval;
		}
	}
}
