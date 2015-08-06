using UnityEngine;
using System.Collections;

public class CameraOutObject : MonoBehaviour {
		Camera mainCamera;
		public float mymargin = 0.01f;
		float minmargin = 0;
		float maxmargin = 1;
		// Use this for initialization
		void Start () {
			//mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
			mainCamera=Camera.main;
			minmargin -= mymargin;
			maxmargin += mymargin;
		}
		
		// Update is called once per frame
		public bool OutScreenObject(Transform playerTransform){
			Vector3 posScreen = mainCamera.WorldToViewportPoint(playerTransform.position);
			posScreen.z = transform.position.z;
			if(posScreen.y <= minmargin || posScreen.y >= maxmargin || posScreen.x <= minmargin || posScreen.x >= maxmargin){
				return true;
			}
			return false;
		}
}