using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;
    [SerializeField] private LayerMask groundLayer;

    public float speed = 3f;

    private void FixedUpdate()
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
        if (isGrounded)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
            
        }
        rb.velocity = new Vector3(-js.Horizontal * speed, rb.velocity.y, -js.Vertical * speed);

        if (js.Horizontal != 0 || js.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
