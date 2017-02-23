using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour {

    private PlayerMovement plyctrl;
    private bool entered = false;

    // Use this for initialization
    void Start () {
        plyctrl = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (entered)
        {
            if (!plyctrl.m_Grounded)
            {
                Application.Quit();
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

}
