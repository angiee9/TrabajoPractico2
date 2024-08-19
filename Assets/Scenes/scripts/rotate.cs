
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] private KeyCode rotdere = KeyCode.E;
    [SerializeField] private KeyCode rotizq = KeyCode.Q;

    void Start()
    {
        
    }

   
    void Update()
    {

        if (Input.GetKeyDown(rotdere))
        {
            transform.Rotate(0f, 0f, -10f));
        }
        if (Input.GetKeyDown(rotizq))
        {
            transform.Rotate(0f, 0f, 10f);
        }
    }
}
