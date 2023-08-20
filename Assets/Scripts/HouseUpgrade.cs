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
        if (collision.gameObject.CompareTag("Gem"))
        {
            health += 0.05f;
            image.fillAmount = health;
        }
    }
  
}
