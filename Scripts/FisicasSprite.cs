using UnityEngine;

public class FisicasSprite : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Choca con"+ collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Trigger con"+ other.gameObject.name);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
