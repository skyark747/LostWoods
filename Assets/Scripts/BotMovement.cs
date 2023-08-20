using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public Animator m_Animator;
    public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public bool isCollided = false;


    //Attack
    public float TimeBetweenAttacks=1f;
    bool AlreadyAttacked=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isCollided=true;
           
            transform.LookAt(other.gameObject.transform);
            Attack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isCollided = false;
        m_Animator.SetBool("IsFiring", false);
    }
    private void Attack()
    {
        //Make sure Enemy dosen't move

        if (!AlreadyAttacked)
        {
            ///Add Attack code
           
            m_Animator.SetBool("IsFiring", true);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            aud.Play();
            ////

            AlreadyAttacked = true;
            Invoke(nameof(ResetAttack), TimeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        AlreadyAttacked = false; 
    }
}
