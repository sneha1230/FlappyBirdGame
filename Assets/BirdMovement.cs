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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(rb.velocity.x, birdSpeed);
        }
        if(rb.velocity.y>0)
        {
            if(angle<=maxAngle)
            {
                angle = angle + 5;
            }
        }
        if (rb.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 5;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
