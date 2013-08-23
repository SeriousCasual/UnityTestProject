﻿using UnityEngine;
using System.Collections;

public class AIScript : MonoBehaviour {	
	
	private Transform target;
	private NavMeshAgent myAgent;

	void Start () {
		target = GameObject.FindWithTag ("Player").transform;
		myAgent = GetComponent<NavMeshAgent>();
			
	}
	
	void Update () {
		myAgent.destination = target.position;
	}
}
