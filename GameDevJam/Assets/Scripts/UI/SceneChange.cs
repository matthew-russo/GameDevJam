using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        startGame();
	}

    void startGame()
    {

        if (Input.GetKeyDown(KeyCode.Return)) SceneManager.LoadScene("main");
    }
}
