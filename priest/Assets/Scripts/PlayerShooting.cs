using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject FireBall;
    public Transform ShotSpawn;
    public float fireRate;
    private float nextFire;
    public AudioClip[] audioClip;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(FireBall, ShotSpawn.position, ShotSpawn.rotation);
            AudioClip clip = null;
            AudioSource audioSrc = (AudioSource)gameObject.GetComponent<AudioSource>();

            float vol = Random.Range(0.2f, 0.5f);
            clip = audioClip[Random.Range(0, 1)];

            audioSrc.PlayOneShot(clip, vol);
        }
    }
}
