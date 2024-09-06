using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballrb;
    [SerializeField] private float initialV = 4f;
    [SerializeField] private float velocityM = 1.0f;    

    

    private void Awake()
    {
        ballrb = GetComponent<Rigidbody2D>();
        Launch();
    }


    private void Launch()
    {
        float xVelocity = Random.Range(0, 5);
        float yVelocity = Random.Range(0, 5);

        if (xVelocity == 0)
        {
            xVelocity = 1;
        }
        else
        {
            xVelocity = -1;
        }
        if (yVelocity == 0)
        {
            yVelocity = 1;
        }
        else
        { 
            yVelocity = -1;
        }
        ballrb.velocity = new Vector2 (xVelocity, yVelocity * initialV);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ballrb.velocity *= velocityM;
        }
    }
}
