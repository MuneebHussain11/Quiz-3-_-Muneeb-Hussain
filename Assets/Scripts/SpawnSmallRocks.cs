using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallRocks : MonoBehaviour
{
    public GameObject splitRockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


 private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Bullet"))
        {
            // Debug.Log("its happening");
        //     // Spawn two new split rocks at the same position as the original rock
            GameObject newRock1 = Instantiate(splitRockPrefab, transform.position, Quaternion.identity);
            GameObject newRock2 = Instantiate(splitRockPrefab, transform.position, Quaternion.identity);

        //     // Adjust velocities to give them an outward direction
            Rigidbody rb1 = newRock1.GetComponent<Rigidbody>();
            Rigidbody rb2 = newRock2.GetComponent<Rigidbody>();
            rb1.velocity = Quaternion.Euler(0, -45, 0) * collision.relativeVelocity;
            rb2.velocity = Quaternion.Euler(0, 45, 0) * collision.relativeVelocity;

        //     // Destroy the original rock
            Destroy(gameObject);
        }

        // if (collision.gameObject.CompareTag("Bullet"))
        // {
        //     Debug.Log("its happening");
        // }
    }
}
