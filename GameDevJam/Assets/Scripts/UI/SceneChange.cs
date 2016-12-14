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

    public void highScore()
    {
        SceneManager.LoadScene("Highscores");
    }

    public void endGame()
    { 
        SceneManager.LoadScene("End");
    }

    public void resetHighscore()
    {
        PlayerPrefs.SetFloat("HighScore", 0);
        PlayerPrefs.SetFloat("HighScore2", 0);
        PlayerPrefs.SetFloat("HighScore3", 0);
        PlayerPrefs.SetFloat("HighScore4", 0);
        PlayerPrefs.SetFloat("HighScore5", 0);

        SceneManager.LoadScene("Highscores");
    }
}
