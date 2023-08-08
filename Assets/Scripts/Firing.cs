using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing : MonoBehaviour
{
    public Animator m_Animator;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;


    void Start()
    {
        
    }

    public void PointerDown()
    {
        m_Animator.SetBool("IsFiring", true);
        var bullet=Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
     
    }

    public void PointerUp()
    {
        m_Animator.SetBool("IsFiring", false);
    }


    void Update()
    {
        
    }
}
