using UnityEngine;
using System.Collections;


//バレット自身のスクリプト
//マウスの方向へ飛んでいき、一定時間で消滅する
public class balet : MonoBehaviour {

	public float power = 100f;//力
	public float des_time = 1f;//消す時間

	// Use this for initialization
	void Start () {

		Vector3 v3mouse = Input.mousePosition;//マウス座標

		//マウスの光線
		Ray rmouse;
		//マウス座標から光線の発射
		rmouse = Camera.main.ScreenPointToRay(v3mouse);

		//光線の向きをvector3に変換
		Vector3 diff  = rmouse.direction.normalized;

		//光線の向きに飛ばす
		this.GetComponent<Rigidbody>().AddForce(diff * power,ForceMode.Impulse);
		//数秒後に破壊
		Destroy(gameObject,des_time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
