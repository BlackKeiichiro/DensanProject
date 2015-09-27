using UnityEngine;
using System.Collections;


/*ボスの攻撃パターンを管理する*/
public class Boss_Atack_main : MonoBehaviour {

	//マネージャーコンポーネント
	Manager mane;

	//次に行う攻撃のパターン
	public int patarn;

	//攻撃の間隔
	public int wait;
	//攻撃の間隔カウント
	public int count;
	//攻撃を開始させる場所のオブジェクト
	GameObject atack_point;
	bool act;//攻撃開始のフラグ

	public float test;

	//ボスの動きを止めるために
	boss_position boss_p;

	//それぞれの攻撃スクリプト
	Boss_Atack lerzer; //レーザー
	public Boss_Missile_Main missile; //ミサイル


	// Use this for initialization
	void Start () {
		//コンポーネント
		mane = GameObject.Find ("Manager").GetComponent<Manager>();
		boss_p = GameObject.Find ("boss_position").GetComponent<boss_position>();
		lerzer = this.GetComponent<Boss_Atack>();
		missile = GameObject.Find ("Missile_Main").GetComponent<Boss_Missile_Main>();

		atack_point = GameObject.Find ("atack_point");
	}

	void Atack(){

		//ミサイルを起動させる
		if(patarn == 0){
			missile.act = true;

		}
		//レーザーを起動させる
		else if(patarn == 1){
			lerzer.act = true;

		}

		//パンチを起動させる
		else{


		}

	}

	// Update is called once per frame
	void Update () {
//		int count = mane.time;

		test = mane.frame_count % wait;
		//カウント加算
		count++;

		//一定間隔で攻撃を行う
		if(count == wait ){
			act = true;

		}
		//一度だけ呼ぶため？（必要ないかも）
		if(act == true){
			if(Mathf.Abs(atack_point.transform.position.x - this.transform.position.x) < 10){
				act = false;
				boss_p.p_act = false;
				Atack ();
			
				patarn = (patarn+1) %3;
			}
		}
		//攻撃後、一定数でボスを動かしてカウントを止める
		if(count == wait+30){
			boss_p.p_act = true;
			count = 0;
		}
	
	}
}
