using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    public Image Himg;
    private bool IsHurt = false;
    float health=1f;

    void FixedUpdate()
    {
        if (IsHurt)
        {
            health -= .1f;
        }
        Himg.fillAmount = health;
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
