using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {
    public GameObject[] clouds = new GameObject[3];
    private GameObject spawn;
    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = 6f;
        spawnPos = new Vector3(transform.position.x + Random.Range(-2f, 2f), transform.position.y + Random.Range(-1f, 3f), transform.position.z);
        spawnRot = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            spawnPos = new Vector3(transform.position.x + Random.Range(-2f, 2f), transform.position.y + Random.Range(-1f, 3f), transform.position.z);
            spawnTime = Random.Range(2f,6f);
            spawn = Instantiate(clouds[Random.Range(0,2)], spawnPos, spawnRot) as GameObject;
            spawn.transform.SetParent(this.transform);
        }
    }
}
