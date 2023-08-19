using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseUpgrade : MonoBehaviour
{
    public Image image;
    public Button button;
    //public Animator MyAnim;
    protected bool IsHurt = false;
    protected bool IsDEad = false;
    public float health = 0f;

    void FixedUpdate()
    {

        if (IsHurt)
        {
            health += 0.005f;
        }
        image.fillAmount = health;
        if (health >= 1f)
        {
            button.enabled = true;
        }
        else
        {
            button.enabled = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            IsHurt = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        IsHurt = false;
    }
}
