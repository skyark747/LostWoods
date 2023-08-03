using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;
    [SerializeField] private LayerMask mask;
    public  AnimationCurve curve;
    public float speed = 3f;
    bool isgrounded = true;
    private void FixedUpdate()
    {
        movement();
    }
    private void Update()
    {
        surfaceallignment();
    }
    private void movement()
    {
        if (isgrounded)
        {
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
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    isgrounded = true;
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    isgrounded=false;
    //}
    private void surfaceallignment()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit Rc = new RaycastHit();

        if (Physics.Raycast(ray, out Rc, 0.1f, mask))
        {
            Quaternion.Lerp(transform.rotation, Quaternion.FromToRotation(Vector3.up, Rc.normal), curve.Evaluate(0.25f));
        }
    }
}
