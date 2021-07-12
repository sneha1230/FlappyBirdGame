using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float groundSpeed;
    BoxCollider2D boxCollider;
    float groundWidth;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
       groundWidth = boxCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + groundSpeed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -groundWidth)
        {
            transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
        }
    }
}
