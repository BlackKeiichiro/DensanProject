using UnityEngine;
using System.Collections;

public class CharactorMove : MonoBehaviour {
	private float angle;
	private float rds = 202;
	private Vector3 center;
	private Vector3 pos;
	private Vector3 _radian;
	private float inity = 1059.5f;//195ずつ間隔でのステージ配置に注意;
	private Manager _manager;
	private GameObject tower;
	void Awake(){
		_manager = GameObject.Find("Manager").GetComponent<Manager>();
	}
	
	// Use this for initialization
	void Start () {
		tower = GameObject.Find("tou0");
		//inity += tower.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		inity -= _manager.fall_speed;
		center = new Vector3(0,inity,0);
		angle += _manager.speed * Time.deltaTime % 360;
		_radian = Vector3.right * rds;
		pos  = Quaternion.AngleAxis(angle,Vector3.up) * _radian;
		this.transform.rotation = Quaternion.Euler(0,30+angle,0);
		this.transform.position = pos + center;
	}
}
