﻿using UnityEngine;
using System.Collections;

public class Shot_Pert1 : MonoBehaviour {
	
	GameObject shot_mouse;//銃口
	public GameObject gbalet;//弾のオブジェクト
	public Manager manager;//マネージャスクリプト
	public int narrow_balet;//弾を撃つ間隔

	public int narrow_root;//銃の角度を変更する間隔
	public int narrow_root_max;//銃の角度を変更する最大待ち時間（ショット時）
	public int narrow_root_min;//銃の角度を変更する最少待ち時間（ノーマル）
	

	AudioSource audio;//オーディオ
	
	//再生する音
	public AudioClip shot;
	
	public Vector3 mouse_p;

	//テスト用変数
	public float ftest;
	public int itest;

	//方向指定用
	Vector3 diff ;
	
	
	// Use this for initialization
	void Start () {
		
		shot_mouse = GameObject.Find ("shot_mouse");//銃口のオブジェクト取得
		manager = GameObject.Find("Manager").GetComponent<Manager>();//ゲーム管理するスクリプトを取得
		audio = GetComponent<AudioSource>();
		
		
	}
	
	Vector3 Mouse(){
		
		//マウスのスクリーン座標取得
		Vector3 v3_mouse = Input.mousePosition;
		//奥行をここで設定
		v3_mouse.z = 30f;
		
		//取得した座標をワールド座標へ変換
		v3_mouse = Camera.main.ScreenToWorldPoint(v3_mouse);
		
		return v3_mouse;
		
	}

	
	//銃口の角度をせってい
	void Mouse_rote(){
		
		diff = Mouse () - this.transform.position;
		this.transform.rotation = Quaternion.LookRotation(diff);

	}
	
	//弾発射
	void Balet(){
		
		//左クリックで通常発射（玉のインスタント化）
		if(Input.GetMouseButton(0) && manager.balet_count >= narrow_balet){
			
			//効果音の再生
			audio.PlayOneShot(shot);
			
			
			//向きたい方向を計算
			Vector3 diff = Mouse() - shot_mouse.transform.position;
			GameObject Balet = Instantiate(gbalet,shot_mouse.transform.position,Quaternion.LookRotation(diff)) as GameObject;
			manager.balet_count = 0;//間隔リセット
			
			//レイを飛ばしてあった当たったオブジェクとを参照
			RaycastHit hit;
			if(Physics.Raycast(shot_mouse.transform.position,diff,out hit,100)){
				if(hit.transform.gameObject.tag == ("point")){
					Point point = hit.transform.gameObject.GetComponent<Point>();
					point.HP -= 1;
					Destroy(Balet,0.1f);
				}
			}
			
			
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0)){
			narrow_root = narrow_root_max;
		}
		else {
			narrow_root = narrow_root_min;
			
		}
		

		if((manager.frame_count % narrow_root) == 0){
			Mouse_rote();
		}

		Balet();
		
	}
}