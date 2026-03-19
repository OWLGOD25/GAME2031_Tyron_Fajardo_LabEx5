using UnityEngine;

public class fallingObjectScript : MonoBehaviour
{
    

    void Start()
    {
        
        Destroy(gameObject, 5f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }
}
