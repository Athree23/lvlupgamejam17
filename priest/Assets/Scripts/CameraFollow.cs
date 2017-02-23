using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class CameraFollow : MonoBehaviour
{

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    [SerializeField]
    private Camera camera;
    private bool m_crouch;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            m_crouch = CrossPlatformInputManager.GetButton("Crouch");

            Vector3 point = camera.WorldToViewportPoint(target.position);
            float z = 10f;
            PlayerMovement plyctrl = (PlayerMovement)target.gameObject.GetComponent<PlayerMovement>();
            if (plyctrl.moving)
            {
                z = 9.5f;
            }

            Vector3 delta;
            if(m_crouch)
            {
                delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.9f, z)); //(new Vector3(0.5, 0.5, point.z));
            }
            else
            {
                delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.3f, z)); //(new Vector3(0.5, 0.5, point.z));
            }
            //delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.3f, z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}

