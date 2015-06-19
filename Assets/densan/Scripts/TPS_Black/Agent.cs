using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour {
	public Transform target;
	public NavMeshAgent agent;
	// Use this for initialization
	void Awake(){
		agent = this.GetComponent<NavMeshAgent>();
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.position);
	}
}
