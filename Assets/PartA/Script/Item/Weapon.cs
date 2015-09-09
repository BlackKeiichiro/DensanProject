using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Weapon : Item {
	private Image gage;
	private bool gage_on = false;
	private float keep_gage = 0;
	// Use this for initialization
	protected override void Start () {
		PositionLock(this.transform.localScale.y);
		gage = GameObject.Find("Canvas/Weapon/Gage").GetComponent<Image>();
	}
	
	// Update is called once per frame
	protected override void Update () {
		if(gage_on && gage.fillAmount-keep_gage < 0.2f)
			gage.fillAmount += 0.01f;
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
			gage_on = true;
			keep_gage = gage.fillAmount;
		}
	}
}
