using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerOffscreen : MonoBehaviour {

    private bool offscreen;
    private Distance distanceScript;
    private string[] prefArray;

	// Use this for initialization
	void Start () {

        distanceScript = (Distance)FindObjectOfType(typeof(Distance));
        prefArray = new string[5]
        {
            "HighScore5", "HighScore4", "HighScore3", "HighScore2", "HighScore"
        };
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
        calculateHS();
        SceneManager.LoadScene("End");        
    }

    private void calculateHS()
    {
        var i = 0;

        PlayerPrefs.SetFloat("LastPoints", Mathf.Round(distanceScript.distanceTotal));

        while (i < 5 && PlayerPrefs.GetFloat("LastPoints") > PlayerPrefs.GetFloat(prefArray[i], 0))
        {
            if (i != 0) PlayerPrefs.SetFloat(prefArray[i - 1], PlayerPrefs.GetFloat(prefArray[i]));

            PlayerPrefs.SetFloat(prefArray[i], PlayerPrefs.GetFloat("LastPoints"));
            i++;
        }

        Debug.Log(PlayerPrefs.GetFloat("HighScore"));
    }
}
