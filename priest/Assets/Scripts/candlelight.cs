using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candlelight : MonoBehaviour
{
    public Light candleLight;
    // Use this for initialization
    void Start()
    {
        candleLight.spotAngle = 90;
        InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);
    }

    // Update is called once per frame
    //void Update () {
    //    candleLight.spotAngle = Random.Range(1, 90);
    //}

    void LaunchProjectile()
    {
        candleLight.spotAngle = Random.Range(60, 70);
        candleLight.intensity = Random.Range(1, 3);
    }
}