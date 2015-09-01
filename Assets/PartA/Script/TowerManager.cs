using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {
	private GameObject[] tower;
	private GameObject _player;
	private float between_margin;
	//private int nowtower = 0;
	// Use this for initialization
	void Start () {
		tower = new GameObject[3]{GameObject.Find("tou0"),GameObject.Find("tou1"),GameObject.Find("tou2")};
		_player = GameObject.Find("Players");
		between_margin = Mathf.Abs(tower[0].transform.position.y - tower[1].transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		if(tower[0].transform.position.y > _player.transform.position.y && between_margin - 30 < Mathf.Abs(tower[0].transform.position.y - _player.transform.position.y)){
			//tower[0].transform.position -= Vector3.up*between_margin*3;
			GameObject localObject = Instantiate(Resources.Load("Prefabs/MainTower"),tower[2].transform.position - Vector3.up*between_margin,Quaternion.Euler(0,160,0)) as GameObject;
			Destroy(tower[0]);
			tower = new GameObject[3]{tower[1],tower[2],localObject};
			//nowtower = (nowtower>1)?0:++nowtower;
		}
	}
}
