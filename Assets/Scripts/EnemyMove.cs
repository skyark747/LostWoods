using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    public GameObject Bear;
    public Transform GoalPoint;
    public float speed = 2f;
    public AudioSource aud;
    private bool IsDead=false;
  
    void Update()
    {
        if (!IsDead)
        {
            transform.LookAt(GoalPoint);
            //Bear.GetComponent<Rigidbody>().velocity = Bear.transform.forward * speed;
        }
        //animator.SetBool("IsRunning", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && !IsDead)
        {
            animator.SetBool("Attack", true);
            aud.Play();
        }
        else if(collision.gameObject.CompareTag("Bullet") && !IsDead)
        {
            animator.SetBool("Dead", true);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("House") && !IsDead)
        {
            animator.SetBool("Attack", true);
        }
        else if(collision.gameObject.CompareTag("BotCircle"))
        {
            FindAnyObjectByType<BotMovement>().DoAttack();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        animator.SetBool("Attack", false);
    }
}
