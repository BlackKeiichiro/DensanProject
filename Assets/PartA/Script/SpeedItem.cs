using UnityEngine;
using System.Collections;

public class SpeedItem : Item {
	[SerializeField]
	float i = 2;
	// Update is called once per frame
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			_manager.speed += 0.5f;
			_manager.fall_speed += 0.0045f;
			Debug.Log("Item");
			Destroy(this.gameObject);
		}
	}
}
