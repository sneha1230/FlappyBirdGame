using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float birdSpeed;
    int angle;
    int minAngle = -90;
    int maxAngle=20;
    public ScoreManager scoreManager;
    bool touchedground;
    public GameManager gameManager;
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&&GameManager.gameOver==false && GameManager.gameIsPaused == false)
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(rb.velocity.x, birdSpeed);
        }
        BirdRotation();
    }
    private void BirdRotation()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 5;
            }
        }
        else if (rb.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 5;
            }
        }
        if (touchedground == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Column"))
        {
            Debug.Log("Scored!");
            scoreManager.Scored();
        }
        if (collision.CompareTag("Pipe"))
        {
            Debug.Log("GameOver!");
            gameManager.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(GameManager.gameOver==false)
            {
                //game over
                gameManager.GameOver();
                BirdDied();
            }
            else
            {
                BirdDied();
            }
        }
    }
    void BirdDied()
    {
        touchedground = true;
        anim.enabled = false;
    }
}
