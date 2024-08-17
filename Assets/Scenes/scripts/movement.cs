
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    public float speed = 0.01f;
    public KeyCode keyup = KeyCode.W;
    public KeyCode keydown = KeyCode.S;
    public KeyCode derecha = KeyCode.D;
    public KeyCode izq = KeyCode.A;
    public KeyCode rotdere = KeyCode.E;
    public KeyCode rotizq = KeyCode.Q;
    public KeyCode colorrandom = KeyCode.R;
    private SpriteRenderer spriterenderer;

   
    private void Awake()    
    {
        spriterenderer = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(keyup))
        {
            pos.y += speed;
        }

        if (Input.GetKey(izq))
        {
            pos.x -= speed;

        }
        if (Input.GetKey(keydown))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(derecha))
        {
            pos.x += speed;

        }
        transform.position = pos;


        if (Input.GetKeyDown(rotdere))
        {
            transform.Rotate(0f, 0f, -10f);
        }
        if (Input.GetKeyDown(rotizq))
        {
            transform.Rotate(0f, 0f, 10f);
        }

        if (Input.GetKeyUp(colorrandom))
        { 
        float blue = Random.Range(0, 1.0f);
        float red = Random.Range(0, 1.0f);
        float green = Random.Range(0, 1.0f);

        spriterenderer.color = new Color (blue, red, green);
        }

    }



    }

        







    

