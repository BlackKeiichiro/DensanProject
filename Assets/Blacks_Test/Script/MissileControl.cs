using UnityEngine;
using System.Collections;

public class MissileControl : MonoBehaviour {

	GameObject player;

	public void Instantiate(){
		Instantiate(GameObject.Find("Cube") as GameObject);
	}

	// Use this for initialization
	public void Start () {
		player = GameObject.Find("Player");
		this.GetComponent<Rigidbody>().AddForce(200*(player.transform.position-this.transform.position));
	}
	
	// Update is called once per frame
	void Update () {

	}
}
