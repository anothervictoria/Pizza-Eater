using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30;
    private float lowBoundary = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy object when it is out of view of camera

        if(transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBoundary)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
