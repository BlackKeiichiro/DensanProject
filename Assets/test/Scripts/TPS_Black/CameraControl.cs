using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	GameObject _player;
	Manager manager;
	public float speed = 0.2f;
	void Awake(){
		manager = (Manager)GameObject.Find("Manager").GetComponent<Manager>();
		_player = GameObject.Find("Player/Players") as GameObject;
	}
	
	// Use this for initialization
	void Start () {
		//this.transform.rotation = _player.transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Vector3.MoveTowards(this.transform.position,_player.transform.localPosition + new Vector3(0,2,-10),Time.deltaTime*20); 
	}
}
