using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.01f;
    [SerializeField] private bool Player;
    [SerializeField] private float ylimit = 3.51f;


   private void Update()
    {

        float movement;

        if (Player)
        {
            movement = Input.GetAxisRaw("Vertical");

        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        Vector2 playerPosition = transform.position;
        playerPosition.y = Mathf.Clamp(playerPosition.y + movement * movementSpeed * Time.deltaTime, -ylimit, ylimit);
        transform.position = playerPosition;

    }
}

