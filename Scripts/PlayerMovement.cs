using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 3f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontal, 0f) * speed * Time.deltaTime;
        transform.Translate(movement.x, movement.y, 0f);

        if (horizontal > 0f)
        {
            spriteRenderer.flipX = true; 
        }
        else if (horizontal < 0f)
        {
            spriteRenderer.flipX = false;  
        }
    }
}

