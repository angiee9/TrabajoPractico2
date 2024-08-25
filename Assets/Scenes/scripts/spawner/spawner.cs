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
            float randomobs = Random.value;
            float randomobs2 = Random.value;

            obstacle = Instantiate(obstaclePrefab, new Vector2(randomobs, randomobs2), Quaternion.identity);
            obstacle2 = Instantiate(obstaclePrefab, new Vector2(randomobs, randomobs2), Quaternion.identity);
            spawned = true;
        }


        if (totalTime > 6)
        {
            obstacle.transform.position += new Vector3(0, 0, 40);
            obstacle2.transform.position += new Vector3(0, 0, 40);
        }

    }
}
