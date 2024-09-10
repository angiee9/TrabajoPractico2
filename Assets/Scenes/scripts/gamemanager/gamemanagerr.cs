using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;



public class Gamemanagerr : MonoBehaviour
{
    [SerializeField] private TMP_Text score1;
    [SerializeField] private TMP_Text score2;

    [SerializeField] private Transform player1Transform;
    [SerializeField] private Transform player2Transform;
    [SerializeField] private Transform ballTransform;

    private int player1Score;
    private int player2Score;

    private static Gamemanagerr instance;

    public static Gamemanagerr Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Gamemanagerr>();
            }
            return instance;
        }
    }

   public void Player1Scored()
    {
        player1Score++;
        score1.text = player1Score.ToString();
    }

    public void Player2Scored()
    {
        player2Score++;
        score2.text = player2Score.ToString();
    }

    public void Restart() 
    {
        player1Transform.position = new Vector2(player1Transform.position.x, 0);
        player2Transform.position = new Vector2(player2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);


    }
}
