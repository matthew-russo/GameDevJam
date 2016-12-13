 using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speed;
    private Rigidbody2D body;
    private int jumpCount;
    public int maxJumps;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        maxJumps = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GlobalPause.Instance.isPaused)
        {
            body.isKinematic = false;
            if (Input.GetButtonDown("Jump"))
            {
                if (jumpCount < maxJumps)
                {
                    Jump();
                }
            }
            if (Input.GetButtonDown("Slam"))
            {
                Slam();
            }
            transform.rotation = Quaternion.identity;
        }
        if (GlobalPause.Instance.isPaused)
        {
            body.isKinematic = true;
        }

        body.position = new Vector3(body.position.x, Mathf.Clamp(transform.position.y, -5, 5.41f), 0);      
    }

    private void Jump()
    {
        body.AddForce(new Vector2(0f, 275f),ForceMode2D.Impulse);
        jumpCount++;
    }

    private void Slam()
    {
        body.AddForce(new Vector2(0f, -400f), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "building")
        {
            jumpCount = 0;
        }
    }
}