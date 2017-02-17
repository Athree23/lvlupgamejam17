using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchAndDie : MonoBehaviour
{
    private PlayerMovement plyctrl;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        plyctrl = (PlayerMovement)other.gameObject.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
            plyctrl.respawn();

    }
}

