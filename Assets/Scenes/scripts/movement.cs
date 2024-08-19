
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    [SerializeField] private KeyCode keyup = KeyCode.W;
    [SerializeField] private KeyCode keydown = KeyCode.S;
    [SerializeField] private KeyCode derecha = KeyCode.D;
    [SerializeField] private KeyCode izq = KeyCode.A;
    [SerializeField] private KeyCode rotdere = KeyCode.E;
    [SerializeField] private KeyCode rotizq = KeyCode.Q;
    [SerializeField] private KeyCode colorrandom = KeyCode.R;
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

    public void setspeed(float movementSpeed)
    {
        speed = movementSpeed;
    }

    }

        







    

