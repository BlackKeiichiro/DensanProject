using UnityEngine;
using System.Collections;

public class CharactorMove : MonoBehaviour {
	private float angle;
	private float rds = 209;
	public float speed = 20;
	private Vector3 center;
	private Vector3 pos;
	private Vector3 _radian;
	private float inity = 195;
	private float fallspeed = 0.7f;
	private RaycastHit hit;
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
		this.transform.rotation = Quaternion.Euler(0,30+angle,0);
		this.transform.position = pos + center;
	}
}
