using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    
    private float spawnRangeLower = 3.0f;
    private float spawnRangeUpper = 5.0f;
    


    // Start is called before the first frame update
    void Start()
    {
        // Call SpawnRandomBall funtion to automatically spawn balls at different time intervals
         float spawnInterval = Random.Range(spawnRangeLower, spawnRangeUpper);
         InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, transform.position.z);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
