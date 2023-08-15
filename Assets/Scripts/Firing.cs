using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing : MonoBehaviour
{
    public Animator m_Animator;
    public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public PlayerHealthbar script;

    public void PointerDown()
    {
            fire();
    }

    private void fire()
    {
        m_Animator.SetBool("IsFiring", true);
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        aud.Play();
    }

    public void PointerUp()
    {
        m_Animator.SetBool("IsFiring", false);
    }

}
