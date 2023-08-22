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
    public float scenechange = 10f;
    public PlayerHealthbar script;
   
    bool move=false;
    public AudioSource aud;
    float Hmove, Vmove;
    public float speed = 2.5f;
    public string sceneName;
    public GameObject panel;
    public GameObject button;
    public GameObject sprite;
    public AudioSource ad;

    private void FixedUpdate()
    {
       

        if (killcount>=this.scenechange)
        {
            ad.enabled = true;
            if (ad.isPlaying == false)
            {
                panel.SetActive(true);
                button.SetActive(true);
                sprite.SetActive(true);
                AudioListener.volume = 0;
                Time.timeScale = 0;
            } 
            
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
