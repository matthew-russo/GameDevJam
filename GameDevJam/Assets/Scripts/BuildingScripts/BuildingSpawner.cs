using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

    public GameObject prefab;
    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float spawnTime;

	// Use this for initialization
	void Start () {
        spawnTime = 2f;
        spawnPos = transform.position;
        spawnRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            spawnTime = 2f;
            Instantiate(prefab, spawnPos, spawnRot);
        }
	}
}
