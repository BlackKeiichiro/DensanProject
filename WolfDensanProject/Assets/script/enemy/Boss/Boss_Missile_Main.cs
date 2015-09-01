using UnityEngine;
using System.Collections;

public class Boss_Missile_Main : MonoBehaviour {

	public GameObject[] misail;//発射するミサイルの配列
	public int first_num = 1; //格納するミサイルの一番若い番号
	public int max_num;		  //格納するミサイルの一番アダルトな番号
	int count_num = 0; //格納するたびにカウントしていく

	public GameObject player;//プレイヤー（カメラ）のオブジェクト
	
	Manager maneger;

	// Use this for initialization
	void Start () {

		//プレイヤーを取得
		player = GameObject.FindWithTag ("Player");		

		maneger = GameObject.Find ("Manager").GetComponent<Manager>();
		

		//count_numが最大番号になるまでくりかえす
		while(count_num != max_num){
			//ミサイルを上から順に格納していく
			misail[count_num] = GameObject.Find("Missile" + (first_num + count_num));
			count_num++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(maneger.act){

		//レーザー起動のタイミング
		if(Input.GetKeyDown(KeyCode.C)){
			count_num=0;
			//count_numが最大番号になるまでくりかえす
			while(count_num != max_num){
			
				//ゲットコンポーネント
				Boss_Misail boss_misail_script = misail[count_num].GetComponent<Boss_Misail>();

				//ミサイルの初期角度の設定
				int misail_dire = boss_misail_script.dire;
				misail[count_num].transform.Rotate(0,45f * misail_dire,0);

				boss_misail_script.diff = misail[count_num].transform.position - player.transform.position;
				boss_misail_script.diff.z = Mathf.Abs(boss_misail_script.diff.z);

				//ミサイルを活動させる
				boss_misail_script.act = true;
				
				count_num++;
			}
				//本体からミサイルを切り離す
				//しばらくは切り離さないようにしておいてね♡
				this.gameObject.transform.DetachChildren();
			

		}
	}
	}
}
