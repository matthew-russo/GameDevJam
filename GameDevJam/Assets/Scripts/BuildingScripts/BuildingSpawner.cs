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
    private Transform[] Spots = new Transform[6];
    private int spot;

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
            spawn = Instantiate(prefab, spawnPos, spawnRot) as GameObject;
            spawn.transform.SetParent(this.transform);
            Spots = spawn.GetComponentsInChildren<Transform>();
            SpawnObstacle();
        }
	}

    private void SpawnObstacle()
    {
        spot = (int)Mathf.Round(Random.Range(1f,Spots.Length));
        Debug.Log(spot);
        ObstacleSpawn = Instantiate(obstPrefab, Spots[spot].position, spawnRot) as GameObject;
        ObstacleSpawn.transform.SetParent(Spots[spot]);
        ObstacleSpawn.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
