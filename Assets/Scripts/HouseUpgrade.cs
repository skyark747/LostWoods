using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseUpgrade : MonoBehaviour
{
    public Image image;
    public GameObject button;
    //public Animator MyAnim;
    protected bool IsHurt = false;
    protected bool IsDEad = false;
    public float health = 0f;

    void FixedUpdate()
    {
        if (health >= 1)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
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
