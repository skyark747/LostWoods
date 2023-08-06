using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing : MonoBehaviour
{
    public Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PointerDown()
    {
        m_Animator.SetBool("IsFiring", true);
    }

    public void PointerUp()
    {
        m_Animator.SetBool("IsFiring", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
