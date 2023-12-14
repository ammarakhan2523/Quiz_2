using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
   
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemyWave(waveNumber);
       

    }

    // Update is called once per frame
    void Update()
    {
       
           //// waveNumber++;
           // spawnEnemyWave(waveNumber);
           

    }

    void spawnEnemyWave(int spawnEnemies)
    {
        for (int i = 0; i < spawnEnemies; i++)
        {
            Instantiate(enemyPrefab, enemyPrefab.transform.position, enemyPrefab.transform.rotation);
        }
    }

   
}
