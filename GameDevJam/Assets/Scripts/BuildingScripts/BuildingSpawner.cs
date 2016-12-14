using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

    public GameObject prefab;
    private GameObject spawn;
    
    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float spawnTime;

    private GameObject ObstacleSpawn;
    public GameObject obstPrefab;
    private Transform[] Spots = new Transform[5];
    private int spot;

    // Use this for initialization
    void Start () {
        spawnTime = 0f;
        spawnPos = transform.position;
        spawnRot = transform.rotation;
        

    }
	
	// Update is called once per frame
	void Update () {
        if (!GlobalPause.Instance.isPaused)
        {
            spawnTime -= Time.deltaTime;
            if (spawnTime < 0)
            {

                spawnTime = Random.Range(1.2f, 1.6f);
                spawn = Instantiate(prefab, new Vector3(spawnPos.x,spawnPos.y + Random.Range(-3.5f,-1.5f)), spawnRot) as GameObject;
                spawn.transform.SetParent(this.transform);
                spawn.transform.localScale = new Vector3(spawn.transform.localScale.x + Random.Range(0f, 1.5f), spawn.transform.localScale.y, spawn.transform.localScale.z);
                Spots = spawn.GetComponentsInChildren<Transform>();
                SpawnObstacle();
            }
        }
        
	}

    private void SpawnObstacle()
    {
        spot = (int)Mathf.Round(Random.Range(1f,5f));
        ObstacleSpawn = Instantiate(obstPrefab, Spots[spot].position, spawnRot) as GameObject;
        ObstacleSpawn.transform.SetParent(Spots[spot]);
        ObstacleSpawn.transform.localScale = new Vector3(3f, 1.5f, 1f);
    }
}
