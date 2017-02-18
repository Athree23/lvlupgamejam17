using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PriestMovement : MonoBehaviour
{
    //goal of the priest
    Transform player;
    Transform priest;
    //distance to player
    private float range;
    //speed to move
    public float speed;
    public float rotationSpeed;

    bool facingLeft = false;
    private Rigidbody2D m_Rigidbody2D;


    // Use this for initialization
    void Start()
    {
        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt(player);
        range = Vector2.Distance(transform.position, player.position);
        if (range <= 10f)
        {
            Vector2 targetDir = new Vector2(player.position.x- transform.position.x, 0);
            print(targetDir);
            //target at the left
            if((targetDir.x < 0f && !facingLeft) || (targetDir.x > 0f && facingLeft))
            {
                flip();
            }
            //transform.rotation = Quaternion.LookRotation(targetDir);

            //seems working but not perfectly
            //transform.position = Vector2.MoveTowards(transform.position, targetDir.normalized, speed * Time.deltaTime);

            m_Rigidbody2D.velocity = new Vector2(targetDir.normalized.x*speed , m_Rigidbody2D.velocity.y);
            //transform.position += transform.forward * speed*Time.deltaTime;
        }
    }
    void flip()
    {
        print(" rotating");
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


        /* player = GameObject.FindGameObjectWithTag("Player").transform;

         range = Vector2.Distance(transform.position, player.position);
         Vector3 targetHeading = player.position - transform.position;
         Vector3 targetDir = targetHeading.normalized;

         //rotate to look at the player
         transform.rotation = Quaternion.LookRotation(targetDir), rotationSpeed*Time.deltaTime;
         transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

         transform.position += transform.forward * Speed * Time.deltaTime;       

         if (range <= 10f)
         {
             transform.Translate(Vector2.MoveTowards(transform.position, player.position, range).normalized * Speed * Time.deltaTime);
         }
         */

       
}
