using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    private PriestHealth priest;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            priest = (PriestHealth)other.gameObject.GetComponent<PriestHealth>();
            priest.Death();
        }

    }
}
