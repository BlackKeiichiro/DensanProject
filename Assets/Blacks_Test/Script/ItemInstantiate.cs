using UnityEngine;
using UnityEditor;
using System.Collections;

public class ItemInstantiate : MonoBehaviour {
	GameObject player;
	Vector3 nowposition;
	Vector3 saveposition;
	Manager _manager;
	public int _radian = 420;
	// Use this for initialization
	void Awake(){
		_manager = GameObject.Find("Manager").GetComponent<Manager>();
		InstatiateObject();
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void InstatiateObject(){
		float inity;
		float i = 0;
		//while(inity > GameObject.Find("Stage/polySurface1").transform.position.y){
		for(inity = 30;inity > GameObject.Find("Stage/polySurface1").transform.position.y;inity -= 1.5f){
			i += 0.1f;
			Vector3 center = new Vector3(0,inity,0);
			float angle = 60 * i % 360;
			Vector3 radian_vector = Vector3.right * _radian;
			Vector3 angle_vector = Quaternion.AngleAxis(angle,Vector3.up) * radian_vector;	
			GameObject localobject =  Instantiate(Resources.Load("Prefab/Item")) as GameObject;
			localobject.transform.position = angle_vector + center;
			if(inity > -200){
				//localobject.transform.localPosition += new Vector3(40*Mathf.Sin(i*1500),0,0);
				localobject.transform.localPosition += new Vector3(20,0,0);
			}
			else if(inity < -200){
				localobject.transform.localPosition -= new Vector3(20,0,0);
			}
		}
	}
}
