using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class enterGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("MENU");
        }

    }
}
