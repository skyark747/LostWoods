using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        
    }


    void Update()
    {
        animator.SetBool("WalkForward", true);
    }
}
