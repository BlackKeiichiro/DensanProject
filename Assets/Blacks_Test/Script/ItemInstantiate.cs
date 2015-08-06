using UnityEngine;
using UnityEditor;
using System.Collections;

public class ItemInstantiate : MonoBehaviour {
	GameObject player;
	Manager _manager;
	float[] itemx = new float[7]{-24,-16,-8,0,8,16,24};
	
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
		GameObject[] localobject = new GameObject[7];
		for(int i = 0;i < 7;i++){
			localobject[i] = Instantiate(Resources.Load("Prefabs/Item")) as GameObject;
			localobject[i].transform.parent = child;
			localobject[i].transform.localPosition = new Vector3(itemx[i],0,0);
		}
	}
}
