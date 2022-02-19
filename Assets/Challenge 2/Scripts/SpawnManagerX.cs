using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
     
    int minDelay = 3;
    int maxDelay = 6;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBall());
    }


    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {     
        
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomNumber = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomNumber], spawnPos, ballPrefabs[randomNumber].transform.rotation);
    }

    IEnumerator SpawnBall()
    {
        yield return new WaitForSeconds(1f);

        while (true)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            int randomNumber = Random.Range(0, 3);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomNumber], spawnPos, ballPrefabs[randomNumber].transform.rotation);

            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
        }        

    }

}
