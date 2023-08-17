using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public Animator m_Animator;
    public GameObject Enemy;
    //public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;


    //Attack
    public float TimeBetweenAttacks=1f;
    bool AlreadyAttacked=false;

    //private void OnCollisionEnter(Collision collision)  
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        transform.LookAt(collision.gameObject.transform);
    //        Attack();
    //    }
    //}
    private void FixedUpdate()
    {
        Attack();
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
