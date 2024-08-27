using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float timeToSpawn;
   
    private float totalTime;
    private bool spawned = false;
    private GameObject obstacle;
    private GameObject obstacle2;
    
    
    


    void Start()
    {
         
        totalTime = 0;
    }


    void Update()
    {

        totalTime += Time.deltaTime;
        if (totalTime > timeToSpawn && !spawned)
        {
            float randomobs = Random.Range(-3, 3.0f);
            float randomobs2 = Random.Range(-3, 3.0f);
            float randomobs2y = Random.Range(-3, 3.0f);
            float randomobsy = Random.Range(-3, 3.0f);

            obstacle = Instantiate(obstaclePrefab, new Vector2(randomobs, randomobsy), Quaternion.identity);
            obstacle2 = Instantiate(obstaclePrefab, new Vector2(randomobs2, randomobs2y), Quaternion.identity);
            spawned = true;
        }

        if (totalTime > 6)
        {
           
            obstacle.SetActive(false);
            obstacle2.SetActive(false);
            
        }



    }
}
    
