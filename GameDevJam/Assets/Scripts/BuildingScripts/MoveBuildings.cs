using UnityEngine;
using System.Collections;

public class MoveBuildings : MonoBehaviour {

    private Vector3 movement;

	// Use this for initialization
	void Start () {
        movement = new Vector3(-.05f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement);
	}
}
