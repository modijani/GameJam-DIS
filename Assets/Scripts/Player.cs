using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private Vector2 direction;
    System.Random rand;

    public float verticalSpeed = 0.05f;
    public float horizontalSpeed = 0.5f;
    public float healthOfPlayer = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        checkIfDead();
        direction = new Vector2(rb.velocity.x, verticalSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int number = rand.Next(0, 10);

            if (number >= 5)
            {
                direction.x = horizontalSpeed;
            }
            else
            {
                direction.x = -horizontalSpeed;
            }
        }

        rb.velocity = new Vector2(direction.x, direction.y);




    }

    private void OnCollisionEnter2D(Collision2D col2d)
    {
        if (col2d.collider.tag == "TrashCan")
        {
            healthOfPlayer -= 50;
            Destroy(col2d.gameObject);
        }

    }

    private void checkIfDead()
    {
        if (healthOfPlayer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
