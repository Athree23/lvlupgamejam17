using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{

    private PlayerMovement plyctrl;
    private bool m_Grounded = false;
    private bool playandwait = true;
    private float prevx = 0;
    private float prevy = 0;
    private Transform tl;
    private Transform tr;
    private Transform bl;
    private Transform br;

    private void Awake()
    {
        tl = transform.Find("TL");
        tr = transform.Find("TR");
        bl = transform.Find("BL");
        br = transform.Find("BR");
    }

    void Start()
    {
        InvokeRepeating("validSound", 2f, 0.4f);
    }

    void Update()
    {
        m_Grounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(tl.position, .1f, 9);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                m_Grounded = true;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource audioSrc = (AudioSource)gameObject.GetComponent<AudioSource>();
            float vol = Random.Range(0.3f, 0.8f);
            audioSrc.PlayOneShot(audioSrc.clip, vol);
        }
        if (m_Grounded && playandwait)
        {
            AudioSource audioSrc = (AudioSource)gameObject.GetComponent<AudioSource>();
            float vol = Random.Range(0.1f, 0.2f);
            audioSrc.PlayOneShot(audioSrc.clip, vol);
            playandwait = false;
        }

    }

    void validSound()
    {
        playandwait = true;
    }
}
