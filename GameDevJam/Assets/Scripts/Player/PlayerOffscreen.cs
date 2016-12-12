using UnityEngine;
using System.Collections;

public class PlayerOffscreen : MonoBehaviour {

    private bool offscreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -7f || transform.position.y <= -5f)
        {
            offscreen = true;
        }

        if (offscreen == true)
        {
            gameOver();
        }
	}

    private void gameOver()
    {
        Time.timeScale = 0;
    }
}
