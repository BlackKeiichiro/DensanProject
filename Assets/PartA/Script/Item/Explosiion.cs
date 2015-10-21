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
		if(BetweenExplosionToPlayer(player,this.gameObject) < 50 && !explosion_flag){
			Debug.Log("Fire");
			explosion_flag = true;
			GameObject localmissile = Instantiate(Resources.Load("Prefabs/Missile")) as GameObject;
			localmissile.GetComponent<Missile>().SetAOE(this.gameObject);
			localmissile.transform.parent = this.transform;
			localmissile.transform.position = player.transform.localPosition + new Vector3(0,50,-20);
		}
	}
	float BetweenExplosionToPlayer(GameObject player,GameObject explosion){
		float x = Mathf.Pow(player.transform.position.x - this.transform.position.x,2);
		float z = Mathf.Pow(player.transform.position.z - this.transform.position.z,2);
		return Mathf.Sqrt(x + z);
	}
}
