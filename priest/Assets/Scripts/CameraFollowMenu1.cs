using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollowMenu1 : MonoBehaviour
{

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    [SerializeField]
    private Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 point = camera.WorldToViewportPoint(target.position);
            float z = 30;
            PlayerMovement plyctrl = (PlayerMovement)target.gameObject.GetComponent<PlayerMovement>();
            if (plyctrl.moving)
            {
                z = 29;
            }
           
            Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.2f, z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}

