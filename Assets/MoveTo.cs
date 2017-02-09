﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {

	public Transform goal;

	void Start () {
		var agent = GetComponent<NavMeshAgent> ();	
		agent.SetDestination (goal.position);
	}
}
