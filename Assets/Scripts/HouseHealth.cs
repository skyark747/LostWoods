using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HouseHealth : MonoBehaviour
{
    public Image img;
    public float health=1f;
    bool Isdamage = false;
    public GameObject panel;

    public void FixedUpdate()
    {
        if(Isdamage)
        {
            health -= 0.001f;
        }
        img.fillAmount = health;
        if(img.fillAmount==0)
        {
            panel.SetActive(true);
            AudioListener.volume = 0;
            Time.timeScale = 0f;
        }

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
