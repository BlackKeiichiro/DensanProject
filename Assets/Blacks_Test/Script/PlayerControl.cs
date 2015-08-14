using UnityEngine;
using System.Collections;
public class PlayerControl : MonoBehaviour {
	[SerializeField]Vector3 _velocity;
	Vector3 respawn;
	RaycastHit hit;
	CameraOutObject cameraOut;
	// Use this for initialization\
	
	void Awake(){
		respawn = this.transform.localPosition;

		cameraOut = (CameraOutObject)this.GetComponent<CameraOutObject>();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		_velocity = new Vector3(h , 0 , v);
		if(v > 0.1)
			_velocity *= Time.deltaTime * 10;
		else if(v < -0.1)
			v = h = 0;
		else
			_velocity *= Time.deltaTime * 5;
		
		this.transform.localPosition -= Vector3.back*0.1f; 
		
		if((h != 0 || v != 0)){
			this.transform.localPosition -= _velocity;
		}
	}
}