using UnityEngine;
using System;
using System.Collections;

public class Explosiion : MonoBehaviour {
	private GameObject player;
	private bool explosion_flag = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
		if(BetweenExplosionToPlayer(player,this.gameObject) < 5 && !explosion_flag){
			explosion_flag = true;

		}

	}
	float BetweenExplosionToPlayer(GameObject player,GameObject explosion){
		float x = Mathf.Pow(player.transform.position.x - this.transform.position.x,2);
		float z = Mathf.Pow(player.transform.position.z - this.transform.position.z,2);
		return Mathf.Sqrt(x + z);
	}
}
