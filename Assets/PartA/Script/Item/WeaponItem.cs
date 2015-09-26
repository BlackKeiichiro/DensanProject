using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponItem : Item {
	private Image gauge;
	private Text level_ui;
	private float keep_gage = 0;

	protected override void Start () {
		PositionLock(this.transform.localScale.y);
		gauge = GameObject.Find("Canvas/Weapon/Gauge").GetComponent<Image>();
		level_ui = GameObject.Find("Canvas/Weapon/Level").GetComponent<Text>();
	}
	
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
            item_manager.OnTriggerCall();
		}
	}

	
}
