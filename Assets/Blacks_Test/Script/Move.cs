using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private float angle = 180;
	private Rigidbody bake_rigidbody;
	// Use this for initialization
	void Start () {
		bake_rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//this.transform.rotation = Quaternion.Euler(0,angle,0);
		bake_rigidbody.AddForce(-1* Vector3.forward*bake_rigidbody.mass*10);
	}
}
