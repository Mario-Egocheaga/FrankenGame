using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject gameOver;

    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            gameOver.SetActive(true);
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
}