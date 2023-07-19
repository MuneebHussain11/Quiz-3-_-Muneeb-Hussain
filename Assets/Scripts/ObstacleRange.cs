using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRange : MonoBehaviour
{
    public float xRange = 10.0f;
    public float zRange = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRange || transform.position.z > zRange )
        {
            transform.position = new Vector3( transform.position.x, transform.position.y, zRange);
        }
    }
}
