using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public Transform player;
    private AudioSource audioSrc;
    public AudioClip[] audioClip;
    private PlayerMovement plyctrl;
    private bool playonce = true;

    void Update()
    {
        plyctrl = (PlayerMovement)player.gameObject.GetComponent<PlayerMovement>();
        if (playonce && !plyctrl.m_Grounded)
        {
            AudioClip clip = null;

            audioSrc = (AudioSource)player.gameObject.GetComponent<AudioSource>();
            //Animator test = (Animator)player.gameObject.GetComponent<Animator>();

            Animator m_Anim = player.GetComponent<Animator>();

            clip = audioClip[Random.Range(0, 1)];

            //audioSrc.Play();

            float vol = Random.Range(0.2f, 0.4f);

            audioSrc.PlayOneShot(clip, vol);
            playonce = false;
        }
        else if (plyctrl.m_Grounded)
        {
            playonce = true;
        }
    }


}

