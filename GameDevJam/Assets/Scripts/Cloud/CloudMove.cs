using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour {

    private Vector3 movement;

    // Use this for initialization
    void Start()
    {
        movement = new Vector3(Random.Range(-.01f,-.015f), 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement);
    }
}
