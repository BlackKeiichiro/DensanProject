﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Missile : MonoBehaviour {
	private GameObject explstnAOE;
	private Rigidbody _rigidbody;
	private float speed = 8;
	// Use this for initialization
	void Start () {
		_rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(explstnAOE != null)
			this.transform.LookAt(explstnAOE.transform);
			_rigidbody.velocity = speed*(explstnAOE.transform.position - this.gameObject.transform.position);
	}

	void OnTriggerEnter(Collider c){
		if(c.transform.tag == "Stage"){
			GameObject localexplsn = Instantiate(Resources.Load("Prefabs/Explosion")) as GameObject; 
			localexplsn.transform.position = this.transform.position;
			localexplsn.transform.parent = explstnAOE.transform;
			Destroy(this.gameObject);
		}
	}

	public void SetAOE(GameObject setAOE){
		explstnAOE = setAOE;
	}
}
