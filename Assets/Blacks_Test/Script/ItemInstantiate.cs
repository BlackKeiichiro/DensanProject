using UnityEngine;
using UnityEditor;
using System.Collections;

public class ItemInstantiate : MonoBehaviour {
	GameObject player;
	Manager _manager;
	float[] itemx = new float[3]{-16,0,16};
	
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
		}
	}
}
