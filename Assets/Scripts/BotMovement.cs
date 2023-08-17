using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public GameObject agent;
    private GameObject enemy;
    public LayerMask WhatIsGround, WhatIsEnemy;
    public Animator m_Animator;
    //public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;


    //Attack
    public float TimeBetweenAttacks;
    bool AlreadyAttacked;


    //States
    public float SightRange, AttackRange;
    public bool PlayerInSightRange, PlayerInAttackRange;

    private void Update()
    {
        PlayerInSightRange = Physics.CheckSphere(transform.position, SightRange, WhatIsEnemy);
        PlayerInAttackRange = Physics.CheckSphere(transform.position, AttackRange, WhatIsEnemy);

        if (PlayerInSightRange && PlayerInAttackRange) 
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
            agent.transform.LookAt(enemy.transform); 
            Attack(); 
        }
    }

    private void ChasePlayer()
    {
        if(gameObject.CompareTag("Enemy"))
            transform.LookAt(gameObject.transform);
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
