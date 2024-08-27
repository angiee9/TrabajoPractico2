using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    void Start()
    {
        
    }

    void Update()
    {
       
       
        if (transform.position.y > 3.8f)
        {
            transform.position = new Vector2(transform.position.x, 3.8f);
        }
        if (transform.position.y < -3.8f)
        {
            transform.position = new Vector2(transform.position.x, -3.8f);
        }
    }
}
