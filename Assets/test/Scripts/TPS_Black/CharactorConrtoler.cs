using UnityEngine;
using System.Collections;

public class CharactorConrtoler : MonoBehaviour {
	[SerializeField]float angle;
	[SerializeField]float _velocity;
	Rigidbody rb;
	float ver;
	float mymargin;
	float maxmargin= 0;
	float minmargin = 1;
	Vector3 saveposition;
	Manager manager;
	public float speed;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("Manager").GetComponent<Manager>();
		rb = GetComponent<Rigidbody>();
	}	
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		if(v > 0.1){
			_velocity = v * Time.deltaTime * 15;
		}
		else if(v < -0.1){
			_velocity = v * Time.deltaTime * 15;
			manager._magnitude -= 0.2f;
		}
		else{_velocity = _velocity = v * Time.deltaTime * 5;
			manager._magnitude -= 0.2f;}
		if(h > 0.1  || h < -0.1){
			ver = h * Time.deltaTime * 7;
			manager._magnitude -= 0.6f;
		}
		
		if(this.transform.position.z > Camera.main.transform.position.z){
			rb.velocity = new Vector3(ver*30,0,_velocity*40);
			manager._magnitude = Vector3.Dot(rb.velocity,transform.forward);
		}
		this.transform.position += new Vector3(0,0,0.2f);
		saveposition = transform.position;
		speed = Vector3.Dot(rb.velocity,transform.forward);
		
	}
}
