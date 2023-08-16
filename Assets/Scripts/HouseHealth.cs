using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseHealth : MonoBehaviour
{
    public Image img;
    public float health=1f;
    bool Isdamage = false;

    public void FixedUpdate()
    {
        if(Isdamage)
        {
            health -= 0.002f;
        }
        img.fillAmount = health;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            this.Isdamage = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        this.Isdamage = false;
    }
}
