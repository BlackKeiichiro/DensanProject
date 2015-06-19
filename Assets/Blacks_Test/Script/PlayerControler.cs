using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += new Vector3(0.3f,0,0);
	}

    void OnTriggerEnter(Collider enterObj) { 
        if(enterObj.gameObject.name == "CheckPoint" + 1){
            GetComponent<Animator>().SetTrigger("Camera");
        }
        if (enterObj.gameObject.name == "CheckPoint" + 2)
        {
            this.transform.position = new Vector3(-31, 1, 0);
        }
    }
}
