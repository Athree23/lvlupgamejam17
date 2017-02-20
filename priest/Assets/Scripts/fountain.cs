using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountain : MonoBehaviour {

    GameObject player;
    PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();

		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            playerHealth.heal();
            Destroy(gameObject);
        }
    }

}
