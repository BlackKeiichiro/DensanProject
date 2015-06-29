﻿using UnityEngine;
using System.Collections;

//ボスの弱点ポイントのスクリプト
public class Point : MonoBehaviour {


	public int MAX_HP = 10;//ポイントの最大ＨＰ
	public int HP;//ポイントの現在ＨＰ
	public float red;//赤以外を減らしていく

	public int Boss_less = 2;//ボスの体力を減らす値
	public int add_score = 50;//スコア加算値

	public Renderer r;//マテリアル用変数
	public Boss boss;//ボス本体のスクリプト
	public Manager manager;//ゲームマネージャー

	private AudioSource audio;//オーディオ
	
	//再生する音
	public AudioClip deth;

	// Use this for initialization
	void Start () {
		HP = MAX_HP;

		//ゲットコンポーネント
		r = GetComponent<Renderer>();//マテリアル用
		boss = GameObject.Find ("BOSS").GetComponent<Boss>();//ボス
		manager = GameObject.Find ("Manager").GetComponent<Manager>();//ゲームマネージャー
		audio = GameObject.Find("shot_mouse").GetComponent<AudioSource>();//オーディオ
		
	}
	
	// Update is called once per frame
	void Update () {

		//ＨＰが０になった時の処理
		if(HP <= 0){
			//効果音の再生
			if(boss.HP > 2){
				audio.PlayOneShot(deth);
			}

			//破壊後ボスのＨＰを減らしてスコアを加算
			Destroy(this.gameObject);
			boss.HP -= Boss_less;
			manager.score += add_score;

		}

		//ＨＰによって赤くする
		red =  HP * 100 / MAX_HP;	//現在のＨＰ割合
		red = red / 100f;
		r.material.color = new Color(1,red,red);
		
	}
}
