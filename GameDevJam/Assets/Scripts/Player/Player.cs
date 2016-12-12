 using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speed;
    private Rigidbody2D body;
    private int jumpCount;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (jumpCount < 2)
            {
                Jump();
            }
        }
        transform.rotation = Quaternion.identity;
    }

    private void Jump()
    {
        body.AddForce(new Vector2(0f, 300f),ForceMode2D.Impulse);
        jumpCount++;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "building")
        {
            jumpCount = 0;
        }
    }
}