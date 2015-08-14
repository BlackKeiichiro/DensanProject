using UnityEngine;
using System.Collections;

public class SpeedItem : Item {

	
	// Update is called once per frame
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			_manager.speed += 5.5f;
			_manager.fall_speed += 0.045f;
			Debug.Log("Item");
			Destroy(this.gameObject);
		}
	}
}
