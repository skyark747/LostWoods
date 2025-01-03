using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    public GameObject Gem;
    public GameObject Zombie;
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
            //Destroy(Zombie);
            this.IsDead = true;
            Gem.SetActive(true);
            FindAnyObjectByType<PlayerMovement>().killcount++;
            GetComponent <CapsuleCollider>().enabled = false;
            aud.Stop();
        }
        else if(collision.gameObject.CompareTag("House") && !IsDead)
        {
            animator.SetBool("Attack", true);
        }
        else if (collision.gameObject.CompareTag("Border") && !IsDead)
        {
            Debug.Log("Collision with border.........");
            gameObject.SetActive(false);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        animator.SetBool("Attack", false);
    }
}
