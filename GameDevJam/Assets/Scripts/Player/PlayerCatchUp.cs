using UnityEngine;
using System.Collections;

public class PlayerCatchUp : MonoBehaviour {

    private float desiredPos;
    private float currentPos;

	// Use this for initialization
	void Start () {
        desiredPos = -3f;
	}
	
	// Update is called once per frame
	void Update () {

	   
        if (transform.position.x >= desiredPos)
        {
            transform.position = new Vector3(desiredPos, transform.position.y, transform.position.z);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag != "obstacle")
        {
            if (col.gameObject.tag == "building")
            {
                if (transform.position.x <= desiredPos)
                {
                    transform.Translate(new Vector3(.02f, 0f, 0f));
                }
            }
        }
        
    }
}
