using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour {

    //public Transform player;
    private PlayerMovement plyctrl;

    private void Awake()
    {
            
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        plyctrl = (PlayerMovement)other.gameObject.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
            plyctrl.setSpawnPoint(transform.position.x, transform.position.y);

    }
}


