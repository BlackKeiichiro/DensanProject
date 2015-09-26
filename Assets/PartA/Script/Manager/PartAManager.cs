using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;


public class PartAManager : MonoBehaviour {
	public int count = 0;
    public int weapon_level = 0;
	public float comp = 0.0f;
	public float spawantime = 0;
	public float speed = 80;
	public float root = 1f;
	public float fall_speed = 0.85f;
	public bool moveflag = false;
    public bool gauge_switch = false;
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
			uitext.text = "TIME:"+count.ToString();
			spawantime = Time.timeSinceLevelLoad + interval;
		}
	}
}
