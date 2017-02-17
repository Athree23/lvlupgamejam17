using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PriestMovement : MonoBehaviour {
    //goal of the priest
    Transform player;
    Transform priest;
    //distance to player
    private float range;
    //speed to move
    public float Speed;
    
	// Use this for initialization
	void Start () {
        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //priest = GameObject.FindGameObjectWithTag("priest").transform;
        

    }
	
	// Update is called once per frame
	void Update () {
        range = Vector2.Distance(transform.position, player.position);
        
        if (range <= 10f)
        {
            transform.Translate(Vector2.MoveTowards(transform.position, player.position, range) * Speed * Time.deltaTime);
        }

		
	}
}
