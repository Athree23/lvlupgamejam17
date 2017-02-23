using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchAndDie : MonoBehaviour
{
    private PlayerHealth plyhealth;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        plyhealth = (PlayerHealth)other.gameObject.GetComponent<PlayerHealth>();
        if (other.tag == "Player")
            plyhealth.Death();
    }
}

