 using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speed;
    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        run();
        jump();      
    }

    public void jump()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0, moveVertical, 0);

        if (moveVertical != 0)
        {
            speed = 10f;
        }

        else speed = 0;

        body.velocity = movement * speed;
    }

    public void run()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);

        if (moveHorizontal != 0)
        {
            speed = 3;
        }

        else speed = 0;

        body.velocity = movement * speed;
    }
}