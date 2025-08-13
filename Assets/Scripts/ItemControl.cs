using UnityEngine;

public class ItemControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int coins;
    public int health;
    public int maxHealth = 100;
    AudioSource audioSource;
    void Start()
    {
        health = maxHealth;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            if (collision.CompareTag("Coin"))
            {
                coins++;
                print($"You have {coins} coins");
                audioSource.Play();
                Destroy(collision.gameObject);
            }
            if (collision.CompareTag("Trap"))
            {
                health -= 10;
                print($"Your health: {health}");
                Destroy(collision.gameObject);
            }
        }
    }
}
