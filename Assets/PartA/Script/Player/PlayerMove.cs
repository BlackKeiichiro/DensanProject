using UnityEngine;
using System;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	private float angle;
	private float speed = 10;
	private float moveDistace;
	private float playerX = 400;
	private Vector3 center;
	private Vector3 radian;
	private Vector3 rotate_position;

	private GameObject player;

	// Use this for initialization
	void Start () {
        center = new Vector3(0,-3.8f,0);
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		moveDistace = h;
        if (h > 0.1 || h < -0.1)
			moveDistace *= Time.deltaTime * 8;
		playerX -= moveDistace;
		angle += speed * Time.deltaTime % 360;
		radian = Vector3.right * playerX;
		rotate_position = Quaternion.AngleAxis(angle,Vector3.up) * radian;
		this.transform.rotation = Quaternion.Euler(0,Define.PLAYER_FIX_ROTATE + angle,0);
		this.transform.position = - rotate_position + center;
	}
}
