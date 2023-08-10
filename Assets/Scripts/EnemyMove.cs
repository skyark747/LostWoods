using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    public Transform GoalPoint;
    void Start()
    {
        
    }


    void Update()
    {
        transform.LookAt(GoalPoint);
        //animator.SetBool("IsRunning", true);
    }
}
