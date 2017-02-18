using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestHealth : MonoBehaviour {

    public float startingHealth = 100f;
    public float currentHealth;
    public AudioClip deathClip;


    Animator anim;
    AudioSource enemyAudio;
    ParticleSystem hitParticles;
    CapsuleCollider2D capsuleCollider;
    bool isDead;
	// Use this for initialization
	void Start () {
        //anim = GetComponent<Animator>();
        //enemyAudio = GetComponent<AudioSource>();
        //hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();

        currentHealth = startingHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage (float amount)
    {

        print("took " + amount + " damage");
        if(isDead)
        {
            return;
        }
        //enemyAudio.Play();  //sound for damage taken

        currentHealth -= amount;

        //hitParticles.transform.position = transform.position;

        //hitParticles.Play();

        //if is dead
        if(currentHealth <= 0f)
        {
            Death();
        }

    }

    public void Death()
    {
        isDead = true;

        //turn the collider into a trigger so shots can pass
        capsuleCollider.isTrigger = true;

        Destroy(gameObject);
        //anim.SetTrigger("Dead");

        //enemyAudio.clip = deathClip;
        //enemyAudio.Play();
    }
}
