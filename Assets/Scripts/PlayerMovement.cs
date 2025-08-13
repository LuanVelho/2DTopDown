using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health;
    public int maxHealth = 100;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("Are you sure this is a Sprite?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) direction.y = 1;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction.x = 1;
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction.x = -1;
            spriteRenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) direction.y = -1;

        transform.position += direction;
        
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 64);
        if (collision != null)
        {
            transform.position -= direction;
        }
    }
}
