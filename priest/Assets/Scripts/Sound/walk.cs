using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    public Transform player;
    private AudioSource audioSrc;
    public AudioClip[] audioClip;
    private PlayerMovement plyctrl;
    private bool enable = false;

    void Update()
    {

        plyctrl = (PlayerMovement)player.gameObject.GetComponent<PlayerMovement>();
        if (plyctrl.moving)
        {
            enable = true;
        }
        else
        {
            enable = false;
        }
        
    }

    void Start()
    {
        InvokeRepeating("LaunchSound", 0f, 0.3f);
    }

    // Update is called once per frame
    //void Update () {
    //    candleLight.spotAngle = Random.Range(1, 90);
    //}

    void LaunchSound()
    {
        if (enable)
        {
            AudioClip clip = null;
            float vol = 1.0f;

            audioSrc = (AudioSource)player.gameObject.GetComponent<AudioSource>();
            //Animator test = (Animator)player.gameObject.GetComponent<Animator>();

            Animator m_Anim = player.GetComponent<Animator>();

            clip = audioClip[Random.Range(0, 2)];

            //audioSrc.Play();

            vol = Random.Range(0.3f, 0.8f);

            audioSrc.PlayOneShot(clip, vol);
        }
    }

}
