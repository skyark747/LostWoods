using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Image img;
    public float health = 1f;
    public bool IsHealthZ = false;

    public void FixedUpdate()
    {
        img.fillAmount = health;
        if (health <= 0)
        {
            IsHealthZ = true;
            FindAnyObjectByType<BossMovement>().animator.SetBool("Dead", true);
            //Destroy(Zombie);
            FindAnyObjectByType<BossMovement>().IsDead = true;
            FindAnyObjectByType<BossMovement>().Gem.SetActive(true);
            FindAnyObjectByType<PlayerMovement>().killcount++;
            Destroy(GetComponent<Rigidbody>());
            FindAnyObjectByType<BossMovement>().aud.Stop();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 0.05f;
        }
    }
}
