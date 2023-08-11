using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;
    bool move=false;
    public AudioSource aud;
    float Hmove, Vmove;
    public float speed = 2.5f;
    private void FixedUpdate()
    {
        movement();     
    }
    private void movement()
    {
        Hmove = -js.Horizontal;
        Vmove = -js.Vertical;

        Vector3 dir=new Vector3(Hmove,0,Vmove);
        rb.velocity=new Vector3(Hmove*speed,rb.velocity.y,Vmove*speed);
        if (dir != Vector3.zero)
        {
            transform.LookAt(transform.position + dir);
            animator.SetBool("IsRunning", true);

        }
        else
        {
            animator.SetBool("IsRunning", false);

        }
      
       
    }
  
}
