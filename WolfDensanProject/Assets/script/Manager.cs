using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//ゲームマネージャースクリプト
public class Manager : MonoBehaviour {

	public float time;//ゲーム開始時からカウントする時間（コンマ秒）
	public int time_second;//ゲーム開始時からカウントする(秒）
	public int frame_count;//ゲーム開始時からカウントするフレームカウント

	public Text score_text;//スコアポイントのテキスト
	public int score;//加算するスコアポイント
	private int score_retain;//スコア保持

	public int balet_count;//弾を打つ間隔

	public float screen_width = Screen.width;//画面サイズ取得
	public float screen_height = Screen.height;//画面サイズ取得


	// Use this for initialization
	void Start () {

		//初期スコアの表示
		score_text.text = "SCORE:"+score_retain;
		
	}
	
	// Update is called once per frame
	void Update () {

		screen_width = Screen.width; //画面横サイズ
		screen_height = Screen.height ;//画面縦サイズ

		//時間のカウント
		time += Time.deltaTime;
		time_second = (int)time;
		//バレット間隔のカウント
		balet_count ++;

		//フレームの加算
		frame_count++;

		//スコアが変わったら変更
		if(score_retain != score){
			score_retain += 5;
			score_text.text = "SCORE:"+score_retain;
		}

	}
}
