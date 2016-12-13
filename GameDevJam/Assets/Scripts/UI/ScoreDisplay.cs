using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {

        score.text = ("You got " + PlayerPrefs.GetFloat("LastPoints") + " points. Your highscore is " + PlayerPrefs.GetFloat("HighScore") + ".");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
