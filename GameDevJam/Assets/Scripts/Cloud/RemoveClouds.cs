using UnityEngine;
using System.Collections;

public class RemoveClouds : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "destroy")
        {
            Debug.Log("hit");
            Destroy(this.gameObject);
        }
    }
}
