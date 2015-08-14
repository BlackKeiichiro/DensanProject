using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private float angle = -20;
	private Rigidbody bake_rigidbody;
	private float rds;
	private float keep = 0;
	// Use this for initialization
	void Start () {
		rds = 206;
		bake_rigidbody = this.GetComponent<Rigidbody>();
		float w = angle*Mathf.PI/180/0.5f;
		Vector3 circle_vector = this.transform.position;
		//Vector3 keep = rds*w*circle_vector;
		//keep.y = this.transform.position.y;
		//this.transform.position = keep;
	}
	
	// Update is called once per frame
	void Update () {
		float w = angle*Mathf.PI/180/0.5f;
		float t = Time.time;
		Vector3 circle_vector = new Vector3(-Mathf.Sin(w*t),-0.3f,Mathf.Cos(w*t));
		bake_rigidbody.velocity = -rds*w*circle_vector;
		//this.transform.Rotate(0,-w,0);
	}
}
