﻿using UnityEngine;
using System.Collections;

public class SpeedItem : Item {
	private RaycastHit hit;
	private LayerMask itemlayer;
	protected override void Start(){
		itemlayer = ~(1 << this.gameObject.layer);
		PositionLock(itemlayer,this.transform.localScale.y);
	}
	// Update is called once per frame
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			if(_manager.fall_speed < 0.45f){
				_manager.speed += 0.5f;
				_manager.fall_speed += 0.01f;
			}
			Destroy(this.gameObject);
		}
	}
}
