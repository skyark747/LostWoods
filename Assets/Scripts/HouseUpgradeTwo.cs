using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseUpgradeTwo : MonoBehaviour
{
    public Image image;
    public GameObject button;

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
            health += 0.03f;
            image.fillAmount = health;
        }
    }
}
