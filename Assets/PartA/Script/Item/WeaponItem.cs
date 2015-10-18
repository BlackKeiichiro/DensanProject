using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponItem : Item {
	private Image gauge;
	private Text level_ui;
    private AudioClip getitemSE;

	protected override void Start () {
		PositionLock(this.transform.localScale.y);
        getitemSE = Resources.Load("Sound/item_bike") as AudioClip;
		gauge = GameObject.Find("Canvas/Weapon/Gauge").GetComponent<Image>();
		level_ui = GameObject.Find("Canvas/Weapon/Level").GetComponent<Text>();
	}
	
	protected override void Update () {
		
	}
	
	protected override void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.tag == "Player"){
            getitemSE.LoadAudioData();
            item_manager.OnTriggerCall();
            AudioSource.PlayClipAtPoint(getitemSE,this.transform.position,0.3f);
			Destroy(this.gameObject);
		}
	}

	
}
