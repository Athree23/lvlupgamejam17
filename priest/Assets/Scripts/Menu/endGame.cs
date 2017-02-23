using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour {

    private PlayerMovement plyctrl;
    private bool entered = false;

    // Use this for initialization
    void Start () {
        plyctrl = null;
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        plyctrl = (PlayerMovement)other.gameObject.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
        {
            SpriteRenderer color = GetComponent<SpriteRenderer>();
            color.color = Color.red;
            Application.LoadLevel("Menu");
        }
    }

}
