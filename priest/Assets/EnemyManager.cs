using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        //call the method Spawn every time spawnTime second
        InvokeRepeating("Spawn", spawnTime, spawnTime);	
	}

    void Spawn()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;         //death
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        //Create an instance of the enemy prefab at the spawnpoint
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
