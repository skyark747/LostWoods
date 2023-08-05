using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthbar : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] float chealth=1000;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            Health();
        }
    }
    void Health()
    {
        img.fillAmount = chealth/1.5f;
    }
}
