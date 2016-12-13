using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {

    public GameObject coinPrefab;
    private GameObject spawn;
    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float spawnTimer;
    public float timeBetweenSpawn;

    // Use this for initialization
    void Start()
    {
        timeBetweenSpawn = 4f;
        spawnTimer = timeBetweenSpawn;
        spawnPos = new Vector3(transform.position.x + Random.Range(0, 4f), transform.position.y + Random.Range(-2f, 2f), transform.position.z);
        spawnRot = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GlobalPause.Instance.isPaused)
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer < 0)
            {
                spawnTimer = timeBetweenSpawn;
                spawnPos = new Vector3(transform.position.x + Random.Range(0, 4f), transform.position.y + Random.Range(-2f, 2f), transform.position.z);
                spawn = Instantiate(coinPrefab, spawnPos, spawnRot) as GameObject;
                spawn.transform.SetParent(this.transform);
            }
        }
    }
}
