using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distance : MonoBehaviour {

    private Text DistanceUIText;
    public float newDistance;
    public float distanceTotal;

	// Use this for initialization
	void Start () {
        DistanceUIText = GetComponent<Text>();
        distanceTotal = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if (!GlobalPause.Instance.isPaused){
	        newDistance = (Time.deltaTime*5f);
            distanceTotal += newDistance;
        }
        DistanceUIText.text = "Distance : " + Mathf.Round(distanceTotal);
	}
}
