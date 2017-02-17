using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public AudioClip deathClip;


    Animator anim;
    AudioSource enemyAudio;
    ParticleSystem hitParticles;
    CapsuleCollider2D capsuleCollider;
    bool isDead;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();

        currentHealth = startingHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage ( int amount)
    {
        if(isDead)
        {
            return;
        }
        enemyAudio.Play();  //sound for damage taken

        currentHealth -= amount;

        hitParticles.transform.position = transform.position;

        hitParticles.Play();

        //if is dead
        if(currentHealth <= 0)
        {
            Death();
        }

    }

    void Death()
    {
        isDead = true;

        //turn the collider into a trigger so shots can pass
        capsuleCollider.isTrigger = true;

        anim.SetTrigger("Dead");

        enemyAudio.clip = deathClip;
        enemyAudio.Play();
    }
}
