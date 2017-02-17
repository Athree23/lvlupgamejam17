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

    // Use this for initialization
    void Start()
    {
        //Looking for object with tag "player"
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //priest = GameObject.FindGameObjectWithTag("priest").transform;


    }

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt(player);
        range = Vector2.Distance(transform.position, player.position);
        if (range <= 10f)
        {

            Vector2 targetDir = new Vector2(player.position.x, transform.position.x).normalized;
            transform.position = Vector2.MoveTowards(transform.position, targetDir, speed * Time.deltaTime);
            //transform.position += transform.forward * speed*Time.deltaTime;
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
}
