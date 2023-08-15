using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float life = 3;
    public GameObject BulletPerfab;
    public GameObject dushman;
    public float _s = 3;
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void Update()
    {
       //transform.LookAt(dushman.transform);
    //    BulletPerfab.GetComponent<Rigidbody>().velocity = BulletPerfab.transform.forward * _s;
    }
    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.CompareTag("Enemy"))
        //    Destroy(collision.gameObject);
        Destroy(gameObject);  
    }
}
