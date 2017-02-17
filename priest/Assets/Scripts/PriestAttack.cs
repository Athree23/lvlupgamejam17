<<<<<<< Updated upstream
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestAttack : MonoBehaviour {
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    PriestHealth priestHealth;
    bool playerInRange;
    float timer;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        priestHealth = GetComponent<PriestHealth>();
        anim = GetComponent<Animator>();
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the entering collider is the player
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //if the exiting collider is the player
        if(collision.gameObject == player)
        {
            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        //if it's time to attack and player in range
        if(timer >= timeBetweenAttacks && playerInRange && priestHealth.currentHealth > 0)
        {
            Attack();
        }

        //if playerDead set the anim
        if(playerHealth.currentHealth <= 0)
        {
            //anim.SetTrigger("PlayerDead");
        }
		
	}
    void Attack()
    {
        //reset timer
        timer = 0f;

        //if player has health to lose
        if(playerHealth.currentHealth > 0)
        {
            //damage the player
            playerHealth.TakeDamage(attackDamage);
        }

    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestAttack : MonoBehaviour {
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    PriestHealth priestHealth;
    bool playerInRange;
    float timer;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        priestHealth = GetComponent<PriestHealth>();
        anim = player.GetComponent<Animator>();
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the entering collider is the player
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //if the exiting collider is the player
        if(collision.gameObject == player)
        {
            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        //if it's time to attack and player in range
        if(timer >= timeBetweenAttacks && playerInRange && priestHealth.currentHealth > 0)
        {
            Attack();
        }

        //if playerDead set the anim
        if(playerHealth.currentHealth <= 0)
        {
            //anim.SetTrigger("PlayerDead");
        }
		
	}
    void Attack()
    {
        //reset timer
        timer = 0f;

        //if player has health to lose
        if(playerHealth.currentHealth > 0)
        {
            //damage the player
            playerHealth.TakeDamage(attackDamage);
        }

    }
}
>>>>>>> Stashed changes
