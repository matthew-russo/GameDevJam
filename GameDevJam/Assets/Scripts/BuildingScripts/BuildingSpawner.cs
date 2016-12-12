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
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            spawnTime = 1.5f;
            spawn = Instantiate(prefab, spawnPos, spawnRot) as GameObject;
            spawn.transform.SetParent(this.transform);
            Spots = spawn.GetComponentsInChildren<Transform>();
            for (int i =0; i < Spots.Length; i++)
            {
                Debug.Log(i);
                Debug.Log(Spots[i]);
            }
            SpawnObstacle();
        }
	}

    private void SpawnObstacle()
    {
        spot = (int)Mathf.Round(Random.Range(1f,5f));
        Debug.Log(spot);
        ObstacleSpawn = Instantiate(obstPrefab, Spots[spot].position, spawnRot) as GameObject;
        ObstacleSpawn.transform.SetParent(Spots[spot]);
        ObstacleSpawn.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
