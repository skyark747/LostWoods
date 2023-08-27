using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    public Image Himg;
    public Animator MyAnim;
    protected bool IsHurt = false;
    public bool IsDEad = false;
    public float health=1f;
  
    void FixedUpdate()
    {
        
        if (IsHurt)
        {
            health -= .05f;
        }
        Himg.fillAmount = health;
        if(health<=0f)
        {
            IsDEad = true;
            MyAnim.SetBool("IsDead", true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            IsHurt = true;         
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        IsHurt = false;
    }

}
