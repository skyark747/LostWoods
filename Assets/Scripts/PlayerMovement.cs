using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private FixedJoystick js;
    public PlayerHealthbar script;
    bool move=false;
    public AudioSource aud;
    float Hmove, Vmove;
    public float speed = 2.5f;
    public int killCount=0;
    public string sceneName;

    private void FixedUpdate()
    {
        if(killCount>=5)
        {
            SceneManager.LoadScene(sceneName);
        }
        if (script.health > 0)
        {
            movement();
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
