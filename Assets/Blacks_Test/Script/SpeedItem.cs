using UnityEngine;
using System.Collections;

public class SpeedItem : Item {

	
	// Update is called once per frame
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			player.GetComponent<CharactorMove>().speed += 1;
			Debug.Log("Item");
			Destroy(this.gameObject);
		}
	}
}
