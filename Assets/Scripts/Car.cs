using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Obstacle
{
    // Start is called before the first frame update
    Rigidbody2D rb2D;
    public float speed;
    public float x;

    public float y;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        setDamage();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(x, y);
        Vector3 movement = input * speed;
        rb2D.velocity = movement;
    }
    protected override void setDamage()
    {
        damage = 25;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Player")
        {
            Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
        }
    }

}
