using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanSpawn : MonoBehaviour
{
    public GameObject ObsSnowman;
    private float timer = 0;
    public float spawnTimer;
    public float timeMin = 0;
    public float timeMax = 5;
    public float distanceMin = 0;
    public float distanceMax = 5;

    void Start()
    {

    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("HERE!");
            SpawnNewObstacle();
            spawnTimer = Random.Range(timeMin, timeMax);
            timer = spawnTimer;
        }

    }

    private void SpawnNewObstacle()
    {
        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(distanceMin, distanceMax);
        spawnPosition.z = 0;
        Instantiate(ObsSnowman, spawnPosition, Quaternion.identity);
    }
}
