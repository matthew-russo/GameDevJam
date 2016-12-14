using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundBuildings : MonoBehaviour {

    public static Vector3 movement;

    // Use this for initialization
    private void Start()
    {
        movement = new Vector3(-2f, 0f, 0f);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!GlobalPause.Instance.isPaused)
        {
            transform.Translate(movement * Time.deltaTime);
        }
    }
}
