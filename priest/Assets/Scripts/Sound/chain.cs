using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour {

    private AudioSource audioSrc;
    public AudioClip[] audioClip;

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
            AudioClip clip = null;
            float vol = 1.0f;

            audioSrc = (AudioSource)gameObject.GetComponent<AudioSource>();

            clip = audioClip[Random.Range(0, 2)];

            //audioSrc.Play();

            vol = Random.Range(0.2f, 0.4f);

            audioSrc.PlayOneShot(clip, vol);
        }

    }
}
