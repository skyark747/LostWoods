using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;
    public float killcount = 0;
    public bool MainAlive = true;
    public float scenechange = 10f;
    public PlayerHealthbar script;

    public AudioSource aud;
    float Hmove, Vmove;
    public float speed = 2.5f;
    public string sceneName;
  

    public int GemCount=0;


    private void FixedUpdate()
    {
       
        if (script.health > 0)
        {
            movement();
        }
        else
        {
            MainAlive = false;
        }
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
            aud.enabled = true;

        }
        else
        {
            animator.SetBool("IsRunning", false);
            aud.enabled=false;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("House"))
        {
            animator.SetBool("IsRunning", false);
        }
    }

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (dir != Vector3.zero)
    //    {
    //        transform.LookAt(transform.position + dir);
    //        animator.SetBool("IsRunning", true);
    //        aud.enabled = true;

    //    }
    //}
}
