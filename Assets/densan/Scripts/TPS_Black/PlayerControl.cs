using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	[SerializeField]Vector3 _velocity;
	[SerializeField]float _magnitude;
	[SerializeField]float lean;
	[SerializeField]float leantimeangle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		_velocity = new Vector3(h , 0 , v);
		if(v > 0.1){
			_velocity *= Time.deltaTime * 10;
		}
		else if(v < -0.1){
			_velocity *=  Time.deltaTime * 8;
		}
		else{
			_velocity *= Time.deltaTime * 5;
		}
		if(h > 0.1){

			_magnitude -= 0.6f;
			lean = Time.deltaTime * leantimeangle;
		}
		else if(h < -0.1){
			_magnitude -= 0.6f;
			lean = Time.deltaTime * (- leantimeangle);
		}
		if(h != 0 || v != 0){
			this.transform.localPosition -= _velocity;
			this.transform.localRotation = Quaternion.Euler(0,0,lean);
		}
	}
}
