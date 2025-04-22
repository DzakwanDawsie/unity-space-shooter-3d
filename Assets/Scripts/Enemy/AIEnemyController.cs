using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]


public class AIEnemyController : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent agent {get; private set;}
	public static float speed = 2;
	GameObject target;

	bool playerInRange;
	float timer;
	// Use this for initialization
	void Start () {
		agent = GetComponentInChildren<NavMeshAgent>();
		target = GameObject.FindGameObjectWithTag("Player");
		agent.updateRotation = true;
		agent.speed = speed;
		agent.updatePosition = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null){
			agent.SetDestination(target.transform.position);
		}
	}


	/// <summary>
	/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>

}
