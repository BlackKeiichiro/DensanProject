using UnityEngine;
using System.Collections;

/*ボスの移動を行う*/
public class boss_position : MonoBehaviour {

	public float p_x;//ボスポジションｘ
	public float p_y;//ポジションｙ
	float count;//カウント変数
	public float r;

	//横移動のオブジェクト
	GameObject position_yoko;
	public float p_x_yoko;
	public float yoko_speed;

	//ポジションアクト
	public bool p_act = true;

	// Use this for initialization
	void Start () {
	
		position_yoko = GameObject.Find ("boss_position_yoko");
	}
	
	// Update is called once per frame
	void Update () {
		//x,yを円で回す

		if(p_act){
			p_x = r * Mathf.Cos(count);
			p_y = r * Mathf.Sin(count);
			p_x_yoko = 1/yoko_speed* Mathf.Sin(count/yoko_speed);



			//p_x = 2f * Mathf.Sin (count + 2);


			this.transform.position += new Vector3(p_x,p_y,0);
			position_yoko.transform.position += new Vector3(p_x_yoko,0,0);

			count += 0.1f;
		}
	}
}
