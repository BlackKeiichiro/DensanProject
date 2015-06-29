using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {

	public float time;//ゲーム開始時からカウントする時間（秒）
	public int count;//ゲーム開始時からカウントする

	public Text score_text;//スコアポイントのテキスト
	public int score;//加算するスコアポイント
	private int score_retain;//スコア保持

	public int balet_count;//弾を打つ間隔

	public float screen_width = Screen.width;//画面サイズ取得
	public float screen_height = Screen.height;//画面サイズ取得


	// Use this for initialization
	void Start () {

		score_text.text = "SCORE:"+score_retain;
		
	}
	
	// Update is called once per frame
	void Update () {

		screen_width = Screen.width; //画面横サイズ
		screen_height = Screen.height ;//画面縦サイズ

		//時間のカウント
		time += Time.deltaTime;
		count = (int)time;
		//バレット間隔のカウント
		balet_count += 1;

		//スコアが変わったら変更
		if(score_retain != score){
			score_retain += 5;
			score_text.text = "SCORE:"+score_retain;
		}

	}
}
