using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlayerController))]
    public class GameControls : MonoBehaviour
    {
        private PlayerController m_Player;
        private bool m_Jump;


        private void Awake()
        {
            m_Player = GetComponent<PlayerController>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Player.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
