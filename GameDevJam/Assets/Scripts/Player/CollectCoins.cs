using UnityEngine;
using System.Collections;
using Patterns;

public class CollectCoins : Singleton<CollectCoins> {
    public float coinCount;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject);
        if (col.gameObject.tag == "coin")
        {
            Destroy(col.gameObject);
            coinCount++;
            
        }
    }
}
