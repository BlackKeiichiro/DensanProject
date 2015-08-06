using UnityEngine;
using System.Collections;

abstract public  class Item : MonoBehaviour {
	Manager manager;
	RaycastHit hit;
	protected GameObject player;
	// Use this for initialization
	protected void Start () {
		player = GameObject.Find("Players") as GameObject;
		manager = GameObject.Find("Manager").GetComponent<Manager>();
		if(Physics.Raycast(this.transform.position+new Vector3(0,this.transform.localScale.y/3,0),Vector3.down,out hit,100)){
			Vector3 pos = hit.point;
			pos.y += this.transform.localScale.y;
			this.transform.position =  pos;
			this.transform.rotation = Quaternion.Euler(hit.normal);
		}
	}
	
	// Update is called once per frame
	protected abstract void Update ();
	
	protected abstract void OnTriggerEnter(Collider _collider);
}
