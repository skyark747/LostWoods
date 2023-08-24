using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShoot : MonoBehaviour
{
    public AudioSource aud;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public bool isCollided = false;

    //Attack
    public float TimeBetweenAttacks = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isCollided = true;

            transform.LookAt(other.gameObject.transform);
            Attack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isCollided = false;
    }
    private void Attack()
    {
        //Make sure Enemy dosen't move

        ///Add Attack code
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        aud.Play();
        gameObject.transform.rotation = Quaternion.identity;
        ////
    }
}
