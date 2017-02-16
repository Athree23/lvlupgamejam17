using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PriestMovement : MonoBehaviour {
    //goal of the priest
    Transform player;
    //reference to pathfinding
    NavMeshAgent nav;
	// Use this for initialization
	void Start () {
        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;

        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.position);

		
	}
}
