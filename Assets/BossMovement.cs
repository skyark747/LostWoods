using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public Animator animator;
    public GameObject Gem;
    public GameObject Zombie;
    public Transform GoalPoint;
    public float speed = 2f;
    public AudioSource aud;
    public bool IsDead = false;

    void Update()
    {
        new WaitForSeconds(6);
        if (!IsDead)
        {
            animator.SetBool("Walk", true);
            transform.LookAt(GoalPoint);
            //Bear.GetComponent<Rigidbody>().velocity = Bear.transform.forward * speed;
        }
        //if(FindAnyObjectByType<EnemyHealth>().IsHealthZ == true)
        //{
        //    animator.SetBool("Dead", true);
        //    //Destroy(Zombie);
        //    this.IsDead = true;
        //    Gem.SetActive(true);
        //    FindAnyObjectByType<PlayerMovement>().killcount++;
        //    GetComponent<MeshCollider>().enabled = false;
        //    aud.Stop();
        //}
        //animator.SetBool("IsRunning", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !IsDead)
        {
            animator.SetBool("Attack", true);
            aud.Play();
        }
        else if (collision.gameObject.CompareTag("House") && !IsDead)
        {
            animator.SetBool("Attack", true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        animator.SetBool("Attack", false);
    }
}
