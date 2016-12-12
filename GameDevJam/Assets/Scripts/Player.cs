 using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
} 

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    private bool started = false;
    
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    private void jump()
    {
        float moveVertical = Input.GetAxis("Vertical");

        Rigidbody2D body = GetComponent<Rigidbody2D>();

        if (moveVertical > 0)
        {
            started = true;
            body.gravityScale = 0.5f;
            body.position = new Vector3(body.position.x, body.position.y + 0.15f, 0);            
        }

        else if (started) body.gravityScale = 1.5f;
    }

}