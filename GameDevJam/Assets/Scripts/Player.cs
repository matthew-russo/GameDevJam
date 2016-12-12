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
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        transform.rotation = Quaternion.identity;
    }

    private void Jump()
    {
        body.AddForce(new Vector2(0f, 325f),ForceMode2D.Impulse);
    }
}