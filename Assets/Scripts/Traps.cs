using UnityEngine;

public class Traps : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health;
    public int maxHealth = 100;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            health -= 10;

            Destroy(collision.gameObject);
        }
    }
}
