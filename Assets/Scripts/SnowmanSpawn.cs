using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanSpawn : MonoBehaviour
{
    public GameObject ObsSnowman;
    private float timer = 0;
    private float spawnTimer = 5;
    private float timeMin = 0;
    private float timeMax = 5;
    private float distanceMin = 0;
    private float distanceMax = 5;
    public Sprite[] snowManAnimation;
    private double animTimer = 0.5;
    private double animCounterTimer = 0;
    public SpriteRenderer sp;
    private int index = 0;
    void Start()
    {
        animCounterTimer = 0;
    }

    void Update()
    {
        //timer -= Time.deltaTime;
        //if (timer <= 0)
        //{
        //    Debug.Log("HERE!");
        //    SpawnNewObstacle();
        //    spawnTimer = Random.Range(timeMin, timeMax);
        //    timer = spawnTimer;
        //}

        animCounterTimer += Time.deltaTime;
        if (animCounterTimer >= index*animTimer)
        {
            if (index >= snowManAnimation.Length)
            {
                index %= snowManAnimation.Length;
            }
           // Debug.Log(animCounterTimer + "------" + index);
            sp.sprite = snowManAnimation[index];
            index++;
        }
    }
    //private void SpawnNewObstacle()
    //{
    //    Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(distanceMin, distanceMax);
    //    spawnPosition.z = 0;
    //    Instantiate(ObsSnowman, spawnPosition, Quaternion.identity);
    //}
}
