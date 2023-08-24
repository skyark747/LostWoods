using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoliZombie : MonoBehaviour
{
    public Animator m_Animator;
    public GameObject AttackSite;
    public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public bool isCollided = false;
    private bool IsDead = false;

    //Attack
    public float TimeBetweenAttacks = 1f;

    private void Update()
    {
        if (!IsDead)
        {
            transform.LookAt(AttackSite.transform);
            //Bear.GetComponent<Rigidbody>().velocity = Bear.transform.forward * speed;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!IsDead)
        {
            if (other.gameObject.CompareTag("House"))
            {
                isCollided = true;

                transform.LookAt(other.gameObject.transform);
                Attack();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isCollided = false;
        m_Animator.SetBool("Attack", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            m_Animator.SetBool("Dead", true);
            IsDead = true;
        }
    }
    private void Attack()
    {
        //Make sure Enemy dosen't move

        ///Add Attack code

        m_Animator.SetBool("Attack", true);
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        aud.Play();
        ////
    }


}
