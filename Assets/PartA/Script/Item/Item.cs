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
		
	}
	
	protected void SetItemType(string itemtype){
		this.itemtype = itemtype;
	}
	
	protected void PositionLock(float scale_y){
		if(Physics.Raycast(this.transform.position,Vector3.down,out hit,50)){
			Vector3 pos = hit.point;
			pos.y += scale_y;
			this.transform.position =  pos;
		}
	}
	
	// Update is called once per frame
	protected abstract void Start();
	protected abstract void Update ();
	
	protected abstract void OnTriggerEnter(Collider _collider);
}
