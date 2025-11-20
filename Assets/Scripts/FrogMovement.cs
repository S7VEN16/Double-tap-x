using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    public float speed = 5f;          // Movement speed
    public float jumpForce = 5f;      // Upward jump force
    private Rigidbody rb;           // Reference to Rigidbody2D

      public float timeLeft = 3f;   // starting time in seconds
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
         timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = new Vector2(2 * speed, rb.velocity.y);
            timeLeft = 3f;
        }
            
        
        

        
    }
}