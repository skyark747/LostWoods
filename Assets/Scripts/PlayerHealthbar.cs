using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] float chealth=1000;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Health();
        }
    }
    void Health()
    {
        img.fillAmount = 0;
    }
}
