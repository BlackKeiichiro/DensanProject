using UnityEngine;
using System.Collections;
[SerializeField]
abstract public  class Item : MonoBehaviour {
	protected Manager _manager;
	protected GameObject _player;
	private RaycastHit hit;
	[SerializeField]
	private string itemtype;
	// Use this for initialization
	protected void Awake(){
		SetItemType(this.GetType().FullName);
		_player = GameObject.Find("Players") as GameObject;
		_manager = GameObject.Find("Manager").GetComponent<Manager>();
		if(Physics.Raycast(this.transform.position+new Vector3(0,this.transform.localScale.y/3,0),Vector3.down,out hit,100)){
			Vector3 pos = hit.point;
			pos.y += this.transform.localScale.y;
			this.transform.position =  pos;
			//this.transform.rotation = Quaternion.Euler(hit.normal);
		}
	}
	
	protected void SetItemType(string itemtype){
		this.itemtype = itemtype;
	}
	
	// Update is called once per frame
	protected abstract void Start();
	protected abstract void Update ();
	
	protected abstract void OnTriggerEnter(Collider _collider);
}
