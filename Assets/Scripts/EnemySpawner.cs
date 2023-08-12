using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject MyEnemy;
    public Transform AttackPos;
    public int EnemyCount;
    public int MaxEnemy;
    public int xPos;
    public int zPos;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

   IEnumerator SpawnEnemy()
   {
        while(EnemyCount < MaxEnemy) 
        {

            xPos = Random.Range(54, 54);
            zPos = Random.Range(29, 43);
            Instantiate(MyEnemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            MyEnemy.GetComponent<Transform>().LookAt(AttackPos);
            yield return new WaitForSeconds(1);
            EnemyCount++;
        }
   }
}

/*Quaternion.identity*/