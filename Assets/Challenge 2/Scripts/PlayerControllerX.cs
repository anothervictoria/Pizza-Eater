using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 0f;
    public float minTimeDelay = 2.0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && time > minTimeDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0f;
            
        }
    }

   
}
