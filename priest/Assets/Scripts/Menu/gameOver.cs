using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

    float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        //if it's time to attack and player in range
        if (timer >= 2)
        {
            Application.LoadLevel("Menu");
        }
    }
}
