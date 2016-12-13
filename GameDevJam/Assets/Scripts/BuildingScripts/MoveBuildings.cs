using UnityEngine;
using System.Collections;

public class MoveBuildings : MonoBehaviour {

    public static Vector3 movement;

	// Use this for initialization
	void Start () {
        movement = new Vector3(-10f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (!GlobalPause.Instance.isPaused)
        {
            transform.Translate(movement*Time.deltaTime);
        }
	}
}
