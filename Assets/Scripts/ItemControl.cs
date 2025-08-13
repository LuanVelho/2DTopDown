using UnityEngine;

public class ItemControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            coins++;

            Destroy(collision.gameObject);
        }
    }
}
