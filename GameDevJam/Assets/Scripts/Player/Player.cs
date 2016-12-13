 using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private float speed;
    private Rigidbody2D body;
    private int jumpCount;
    public int maxJumps;
    private Vector3 previousVelocity;
    private ParticleSystem _particleSystem;


    // Use this for initialization
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        maxJumps = 2;
        _particleSystem = GetComponentInChildren<ParticleSystem>();

    }

    // Update is called once per frame
    private void Update()
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
            
            body.position = new Vector3(body.position.x, Mathf.Clamp(transform.position.y, -5, 5.41f), 0);
        }
        if (GlobalPause.Instance.isPaused)
        {
            body.isKinematic = true;
            previousVelocity = body.velocity;
            body.velocity = new Vector3(0f,0f,0f);
        }

        transform.rotation = Quaternion.identity;
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

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "building")
        {
            _particleSystem.Play();
            jumpCount = 0;
        }
    }
}