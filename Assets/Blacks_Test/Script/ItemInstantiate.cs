using UnityEngine;
using UnityEditor;
using System.Collections;

public class ItemInstantiate : MonoBehaviour {
	GameObject player;
	Vector3 nowposition;
	Vector3 saveposition;
	Manager _manager;
	int mycount = -1;
	// Use this for initialization
	void Awake(){
		float inity = 665;
		float i = 0;
		while(inity > -205){
			i += 0.1f;
			Vector3 center = new Vector3(0,inity,0);
			float angle = 50* i %360;
			inity -= 1.3f;
			Vector3 _radian = Vector3.right * 420;
			Vector3 pos = Quaternion.AngleAxis(angle,Vector3.up)*_radian;	
			GameObject localobject =  Instantiate(Resources.Load("Prefab/Item")) as GameObject;
			localobject.transform.position = pos + center;
			Undo.RegisterCreatedObjectUndo(localobject, "CreateObject");
		}
	}
	
	void Start () {
		_manager = GameObject.Find("Manager").GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		/*if(_manager.count - mycount> 1){
			mycount = _manager.count;
			saveposition = player.transform.position;
			Vector3 item_position = player.transform.localPosition;
			item_position.y -= 120;
			GameObject localobject =  Instantiate(Resources.Load("Prefab/Item")) as GameObject;
			localobject.transform.position = item_position;
		}*/		
	}
	/*void InstantiateObj(){
		float inity = 648;
		float i = 0;
		while(inity > -205){
			i += 0.1f;
			Vector3 center = new Vector3(0,inity,0);
			float angle = 50* i %360;
			inity -= 3f;
			Vector3 _radian = Vector3.right * 410;
			Vector3 pos = Quaternion.AngleAxis(angle,Vector3.up)*_radian;	
			GameObject localobject =  Instantiate(Resources.Load("Prefab/Item")) as GameObject;
			localobject.transform.position = pos + center;
			Undo.RegisterCreatedObjectUndo(localobject, "CreateObject");
		}
	}*/
}
