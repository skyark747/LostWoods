using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;

    public float speed = 3f;

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(-js.Horizontal * speed, rb.velocity.y, -js.Vertical * speed);
        if (js.Horizontal != 0 || js.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }
}
