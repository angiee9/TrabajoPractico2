
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    [SerializeField] private KeyCode keyup = KeyCode.W;
    [SerializeField] private KeyCode keydown = KeyCode.S;
   
   

   


    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(keyup))
        {
            pos.y += speed * Time.deltaTime * 1000;
        }
        if (Input.GetKey(keydown))
        {
            pos.y -= speed * Time.deltaTime * 1000;
        }

        transform.position = pos;


    }

    public void setspeed(float movementSpeed)
    {
        speed = movementSpeed;
    }

    }

        







    

