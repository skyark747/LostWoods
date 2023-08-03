using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float moveSpeed;

    private void Update()
    {
        rb.velocity = new Vector3(_joystick.Horizontal * moveSpeed, rb.velocity.y, _joystick.Vertical * moveSpeed);

        if ((_joystick.Horizontal >= -0.5 && _joystick.Horizontal <= 0.5) && _joystick.Vertical >= 0.9)
        {
            //transform.rotation = Quaternion.LookRotation(rb.velocity);
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
    }
}
