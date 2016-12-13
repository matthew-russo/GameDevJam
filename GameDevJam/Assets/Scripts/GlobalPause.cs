using UnityEngine;
using System.Collections;
using Patterns;

public class GlobalPause : Singleton<GlobalPause> {

    public bool isPaused;

	// Use this for initialization
	void Start () {
        isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.W))
        {
            isPaused = !isPaused;
        }
	}
}
