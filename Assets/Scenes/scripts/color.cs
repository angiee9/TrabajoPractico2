
using UnityEngine;

public class color : MonoBehaviour
{
    [SerializeField] private KeyCode colorrandom = KeyCode.R;
    private SpriteRenderer spriterenderer;


    private void Awake()
    {
        spriterenderer = GetComponent<SpriteRenderer>();

    }



    void Update()
    {

        if (Input.GetKeyUp(colorrandom))
        {
            float blue = Random.Range(0, 1.0f);
            float red = Random.Range(0, 1.0f);
            float green = Random.Range(0, 1.0f);

            spriterenderer.color = new Color(blue, red, green);
        }
    }
}
