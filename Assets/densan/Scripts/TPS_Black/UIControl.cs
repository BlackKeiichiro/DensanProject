using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {
	Manager mng;
	// Use this for initialization
	void Start () {
		mng = GameObject.Find("Manager").GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(mng._magnitude > 0)
		{
			this.GetComponent<Image>().fillAmount = mng._magnitude/10;
		}
	}
}
