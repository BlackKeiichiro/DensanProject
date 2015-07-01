using UnityEngine;
using System.Collections;

public class CharactorMove : MonoBehaviour {
	public float angle;
	public float rds = 10;
	public float speed = 20;
	Vector3 center;
	Vector3 pos;
	Vector3 _radian;
	public float inity = 30;
	public float fallspeed = 0.3f;
	void Awake(){

	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		inity -= fallspeed;
		center = new Vector3(0,inity,0);
		angle += speed * Time.deltaTime % 360;
		_radian = Vector3.right * rds;
		pos  = Quaternion.AngleAxis(angle,Vector3.up) * _radian;
		transform.rotation = Quaternion.Euler(0,angle,0);
		this.transform.position = pos + center;
		
	}
}
