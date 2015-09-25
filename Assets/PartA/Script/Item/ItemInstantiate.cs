using UnityEngine;

using System.Collections;
using System.Collections.Generic;
public class ItemInstantiate : MonoBehaviour {
	private float[] item_x = new float[]{-48,-42,-36,-30,-24,-18,-12,-6,0,6,12,18,24,30,36,42,48};
	private GameObject[] type_items;
	private List<Transform> itemzone_child = new List<Transform>();
	private PartAManager manager;
	//public Item[] instant_items;

	void Awake(){
		foreach(Transform child in this.transform){
			itemzone_child.Add(child);
		}
		manager = GameObject.Find("Manager").GetComponent<PartAManager>();
		type_items = new GameObject[]{
			 Resources.Load("Prefabs/Wall") as GameObject,
			 Resources.Load("Prefabs/Weapon") as GameObject,
		};
	}
	void Start () {
		int random = Random.Range(0,1);
		GameObject[] localobject = new GameObject[item_x.Length];
		for(int zoneindex = 0;zoneindex < itemzone_child.Count - 1;zoneindex++){
			for(int itemindex = 0;itemindex < item_x.Length;itemindex++){
				localobject[itemindex] = Instantiate(type_items[manager.patternlist[0,zoneindex,itemindex]]) as GameObject;
				localobject[itemindex].transform.parent = itemzone_child[zoneindex];
				localobject[itemindex].transform.localRotation = Quaternion.Euler(Vector3.zero);
				localobject[itemindex].transform.localPosition = new Vector3(item_x[itemindex],-10,0);

			}
		}
	}
}
