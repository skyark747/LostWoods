using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject MyEnemy;
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
        while(EnemyCount<=0) 
        {

            xPos = Random.Range(54, 54);
            zPos = Random.Range(29, 43);
            Instantiate(MyEnemy, new Vector3(xPos, 2.372385f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1);
            EnemyCount++;
        }
   }
}
