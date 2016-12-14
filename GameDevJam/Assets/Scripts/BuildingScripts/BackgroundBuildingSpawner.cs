using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBuildingSpawner : MonoBehaviour {

    public GameObject prefab;
    private GameObject spawn;

    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = 2f;
        spawnPos = transform.position;
        spawnRot = transform.rotation;


    }

    // Update is called once per frame
    void Update()
    {
        if (!GlobalPause.Instance.isPaused)
        {
            spawnTime -= Time.deltaTime;
            if (spawnTime < 0)
            {
                spawnTime = Random.Range(6.0f, 10.0f);
                spawn = Instantiate(prefab, spawnPos, spawnRot) as GameObject;
                spawn.transform.SetParent(this.transform);
            }
        }

    }

}
