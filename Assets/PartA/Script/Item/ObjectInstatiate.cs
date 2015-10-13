using UnityEngine;
using System.Collections;

public class ObjectInstatiate : MonoBehaviour {
	private int pass_zone = 1;
	private float rds = 400;
	private float angle = 0;
	private Vector3 radian;
	private Vector3 center;
	private Vector3 rotate_position;
	private GameObject[] itemzones;
	private GameObject[] kindobject;
	// Use this for initialization
	void Start () {
		center = Vector3.zero;
		itemzones = new GameObject[]{
			this.transform.FindChild("ItemzoneRight").gameObject,
			this.transform.FindChild("ItemzoneLeft").gameObject
		};
		kindobject = new GameObject[]{
			Resources.Load("Prefabs/Weapon") as GameObject,
			Resources.Load("Prefabs/ExplosionAOE") as GameObject
		};
		ObjectUpdate();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void ObjectUpdate(){
		for(int zoneindex = 0;zoneindex < 6;zoneindex++){
			GameObject localparent = new GameObject();
			radian = - rds * Vector3.right; 
			rotate_position = Quaternion.AngleAxis(angle,Vector3.up) * radian;
			localparent.transform.position = center + rotate_position;
			localparent.transform.rotation = Quaternion.Euler(Vector3.up * angle);
			angle += 30;
			localparent.transform.parent = itemzones[pass_zone].transform;
			//item[pass_zone,zoneindex] = localparent;
			for(int i = 0;i < 5;i++){
				GameObject localobject = Instantiate((zoneindex == 0)?kindobject[0]:kindobject[1]) as GameObject;
				localobject.transform.parent = localparent.transform;
				localobject.transform.localPosition = new Vector3(Define.ITEM_FiRST_SIDE - Define.BETWEEN_ITEM * i,-3.7f,0);
			}
		}
		pass_zone = (pass_zone == 0)?pass_zone++:0;
	}


	void OnTriggerEnter(Collider _collider){
		if(_collider.transform.gameObject.tag == "Player"){
			foreach(Transform child in this.transform){
				foreach(Transform item in child.transform){
					Destroy(item.gameObject);
				}
			}
			ObjectUpdate();
		}
	}
}
