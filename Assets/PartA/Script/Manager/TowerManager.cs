using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {
	[SerializeField]
	private GameObject[] tower;
	private GameObject _player;
	[SerializeField]
	private float between_margin;
	[SerializeField]
	private float keep;
	//private int nowtower = 0;
	// Use this for initialization
	void Start () {
		tower = new GameObject[3]{GameObject.Find("tou0"),GameObject.Find("tou1"),GameObject.Find("tou2")};
		_player = GameObject.Find("Players").transform.FindChild("Main Camera").gameObject;
		between_margin = Mathf.Abs(tower[0].transform.position.y - tower[1].transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		keep = _player.transform.position.y;
		if(tower[0].transform.position.y - between_margin > _player.transform.position.y ){//&& between_margin < Mathf.Abs(tower[0].transform.position.y - _player.transform.position.y)){
			GameObject localObject = Instantiate(Resources.Load("Prefabs/maintou")) as GameObject;
			localObject.transform.position = tower[2].transform.position - Vector3.up * between_margin;
			localObject.transform.rotation = Quaternion.Euler(Vector3.zero);
			Destroy(tower[0]);
			tower = new GameObject[3]{tower[1],tower[2],localObject};
			//nowtower = (nowtower>1)?0:++nowtower;
		}
	}
}
