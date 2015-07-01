using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	RaycastHit hit;
	GameObject player;
	Manager manager;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Players") as GameObject;
		manager = GameObject.Find("Manager").GetComponent<Manager>();
		
		if(Physics.Raycast(this.transform.position+new Vector3(0,this.transform.localScale.y/3,0),Vector3.down,out hit,150)){
			Debug.Log(hit.transform.gameObject.name);
			Vector3 pos = hit.point;
			pos.y += this.transform.localScale.y;
			this.transform.position =  pos;
			this.transform.rotation = Quaternion.Euler(hit.normal);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			player.GetComponent<CharactorMove>().speed += 1;
			Debug.Log("Item");
			Destroy(this.gameObject);
		}
	}
}
