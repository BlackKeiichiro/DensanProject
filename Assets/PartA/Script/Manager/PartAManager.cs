using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;


public class PartAManager : MonoBehaviour {
    public int count;
    public int weapon_level = 0;
	public float dcount = 0.0f;
	public float speed = 40;
	public float root = 1f;
	public float fall_speed = 0.85f;
	public bool moveflag = false;
    public bool gauge_switch = false;
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
		dcount += Time.deltaTime;
		count = Convert.ToInt32 (dcount);
        uitext.text = "TIME:" + string.Format("{0:N}\r\n",dcount).ToString();
	}
}
