using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;


    void Start()
    {
        Instantiate(obstaclePrefab, new Vector2(0, 0), Quaternion.identity);
    }

   
    void Update()
    {
        
    }
}
