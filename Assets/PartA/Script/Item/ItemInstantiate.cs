using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemInstantiate : MonoBehaviour {
    private int itemcount = 17;
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
		GameObject[] localobject = new GameObject[Define.ITEM_COUNT];
		for(int zoneindex = 0;zoneindex < itemzone_child.Count - 1;zoneindex++){
			for(int itemindex = 0;itemindex < Define.ITEM_COUNT;itemindex++){
				localobject[itemindex] = Instantiate(type_items[manager.patternlist[0,zoneindex,itemindex]]) as GameObject;
				localobject[itemindex].transform.parent = itemzone_child[zoneindex];
				localobject[itemindex].transform.localRotation = Quaternion.Euler(Vector3.zero);
                localobject[itemindex].transform.localPosition = new Vector3(- Define.ITEM_FiRST_SIDE + Define.BETWEEN_ITEM * itemindex, -10, 0);
			}
		}
	}
}
