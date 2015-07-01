using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {
	Manager manager;
	void Start () {
		manager = GameObject.Find("Manager").GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(manager._magnitude > 0)
		{
			this.GetComponent<Image>().fillAmount = manager._magnitude/10;
		}
	}
}
