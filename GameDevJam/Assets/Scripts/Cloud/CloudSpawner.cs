using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {
    public GameObject[] clouds = new GameObject[3];
    private Vector3[] spawnPos = new Vector3[3];
    private Quaternion spawnRot;
    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = 6f;
        clouds = GameObject.FindGameObjectsWithTag("cloud");
        for (int i = 0; i<clouds.Length; i++)
        {
            spawnPos[i] = clouds[i].transform.position;
        }
        spawnRot = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            spawnTime = 6f;
            Instantiate(clouds[Random.Range(0,2)], spawnPos[Random.Range(0, 2)], spawnRot);
        }
    }
}
