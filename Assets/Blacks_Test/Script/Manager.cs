using UnityEngine;
using System;
using System.Collections;

public class Manager : MonoBehaviour {
	public int count = 0;
	public float comp = 0.0f;
	public float spawantime = 0;
	public float root = 1f;
	public bool moveflag = false;
	float interval = 1.0f;
	public int partswitch;
	public float _magnitude;
	
	void Awake(){
		/*switch(Application.loadedLevelName){
			case "test":
			partswitch = 0;
			break;
			case "test2":
			partswitch = 1;
			break;
		}*/
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		comp += Time.deltaTime;
		count = Convert.ToInt32 (comp);
		if(spawantime < Time.timeSinceLevelLoad){
			spawantime = Time.timeSinceLevelLoad + interval;
		}
	}
}
