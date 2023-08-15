using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask WhatIsGround, WhatIsPlayer;


    //Patroling
    public Vector3 WalkPoint;
    public bool WalkPointSet;
    public float WalkPointRange;

    //Attack
    public float TimeBetweenAttacks;
    bool AlreadyAttacked;


    //States
    public float SightRange, AttackRange;
    public bool PlayerInSightRange, PlayerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Enemy").transform;
        agent=GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        PlayerInSightRange = Physics.CheckSphere(transform.position, SightRange, WhatIsPlayer);
        PlayerInAttackRange = Physics.CheckSphere(transform.position, AttackRange, WhatIsPlayer);

        if (!PlayerInSightRange && !PlayerInAttackRange) Patrolling();
        if (PlayerInSightRange && !PlayerInAttackRange) ChasePlayer();
        if (PlayerInSightRange && PlayerInAttackRange) Attack();
    }

    private void Patrolling()
    {
        if (!WalkPointSet) SearchWalkPoint();

        if(WalkPointSet)
        {
            agent.SetDestination(WalkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - WalkPoint;

        //WalkPoint Reached
        if(distanceToWalkPoint.magnitude<1f)
        {
            WalkPointSet = false;
        }
    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-WalkPointRange, WalkPointRange);
        float randomX = Random.Range(-WalkPointRange, WalkPointRange);

        WalkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(WalkPoint,-transform.up,2f,WhatIsGround))
        {
            WalkPointSet = true;
        }
    }
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
    private void Attack()
    {
        //Make sure Enemy dosen't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if(!AlreadyAttacked)
        {
            ///Add Attack code
            

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
