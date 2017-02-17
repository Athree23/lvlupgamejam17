using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMover : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    private PlayerMovement player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = (PlayerMovement)GameObject.FindObjectOfType(typeof(PlayerMovement));
        Vector2 dir = new Vector2(player.getDir(), 0);
        rb.AddForce(dir*speed);
    }
}
