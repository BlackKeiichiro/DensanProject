using UnityEngine;
using System.Collections;

/*ボスの移動を行う*/
public class boss_position : MonoBehaviour {

	public float p_x;//ボスポジションｘ
	public float p_y;//ポジションｙ
	float count;//カウント変数
	public float r;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//x,yを円で回す
		p_x = r * Mathf.Cos(count);
		p_y = r * Mathf.Sin(count);
		this.transform.position += new Vector3(p_x,p_y,0);
		count += 0.1f;
	}
}
