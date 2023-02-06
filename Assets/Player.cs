using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private Vector2 direction;
    System.Random rand;

    public float speed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int number = rand.Next(0, 10);
            direction = new Vector2(0, 0);

            if (number >= 5)
            {
                direction.x = 1;
            }
            else
            {
                direction.x = -1;
            }
        }

    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
}
