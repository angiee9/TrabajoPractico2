using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballrb;
    [SerializeField] private float initialV = 0.7f;
    [SerializeField] private float velocityM = 1.0f;    

    

    private void Awake()
    {
        ballrb = GetComponent<Rigidbody2D>();
        Launch();
    }


    private void Launch()
    {
        Vector2 velocity = Vector2.zero;
        do
        {
            velocity.x = Random.Range(-5, 5);
            velocity.y = Random.Range(-5, 5);
            velocity.Normalize();
        } while (Mathf.Abs(velocity.y) > Mathf.Abs(velocity.x));
        
        
        ballrb.velocity = velocity * initialV;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ballrb.velocity *= velocityM;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("goal1"))
        {
            Gamemanagerr.Instance.Player2Scored();
            Gamemanagerr.Instance.Restart();
            Launch();
        }
        else
        {
            Gamemanagerr.Instance.Player1Scored();
            Gamemanagerr.Instance.Restart();
            Launch();
        }
    }

}
