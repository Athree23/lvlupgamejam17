using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour {

    private AudioSource audioSrc;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            audioSrc = (AudioSource)gameObject.GetComponent<AudioSource>();

            float vol = Random.Range(0.2f, 0.4f);

            audioSrc.PlayOneShot(audioSrc.clip, vol);
        }

    }
}
