using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour {

    private PlayerMovement plyctrl;
    private bool entered = false;
    private bool executeonce = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (entered)
        {
            if (!plyctrl.m_Grounded)
            {
                if (executeonce)
                {
                    Invoke("load", 1f);
                    executeonce = false;
                }

            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        plyctrl = (PlayerMovement)other.gameObject.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
        {
            SpriteRenderer color = GetComponent<SpriteRenderer>();
            color.color = Color.red;
            entered = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        plyctrl = (PlayerMovement)other.gameObject.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
        {
            SpriteRenderer color = GetComponent<SpriteRenderer>();
            color.color = Color.white;
            entered = false;
        }
    }

    void load()
    {
        Application.LoadLevel("world_lvl1");
    }

}
