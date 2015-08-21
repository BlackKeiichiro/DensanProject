using UnityEngine;
using UnityEditor;
using System;
using System.Collections;

public class ItemInstantiate : MonoBehaviour {
	GameObject player;
	Manager _manager;
	[SerializeField]
	float[] itemx = new float[3]{-10,0,10};      
	public int [,] num = new int[2,2]{{1,2},{3,4}};
	string speeditem = "Prefabs/SpeedItem";
	string wall = "Prefabs/Wall";
	string wepon = "Prefabs/Wepon";
	public Item[] _item = new Item[3];
	void Awake(){
		_manager = GameObject.Find("Manager").GetComponent<Manager>();
		player = GameObject.Find("Players");
	}
	void Start () {
		foreach(Transform child in this.transform){
			InstatiateObject(child);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void InstatiateObject(Transform child){
		GameObject[] localobject = new GameObject[3];
		for(int i = 0;i < 3;i++){
			localobject[i] = Instantiate(Resources.Load("Prefabs/SpeedItem")) as GameObject;
			localobject[i].transform.parent = child;
			localobject[i].transform.localPosition = new Vector3(itemx[i],0,0);
			_item[i] = localobject[i].GetComponent<Item>();
		}
	}
}
