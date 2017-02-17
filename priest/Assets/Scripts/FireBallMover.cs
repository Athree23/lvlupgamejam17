using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMover : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UnityStandardAssets._2D.PlayerController player = (UnityStandardAssets._2D.PlayerController)GameObject.FindObjectOfType(typeof(UnityStandardAssets._2D.PlayerController));
        Vector2 dir = new Vector2(player.getDir(), 0);
        rb.AddForce(dir*speed);
    }
}
