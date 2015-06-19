using UnityEngine;
using System.Collections;

public class Maneger : MonoBehaviour {
    public bool cameraswitch = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Instantiate(){
		GameObject obj = Instantiate(GameObject.Find("Cube")) as GameObject;
		obj.transform.position = Vector3.zero;
	}
}
