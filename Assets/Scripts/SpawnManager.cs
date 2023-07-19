using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefabs;
    private float spawnRangeX = 10;
    public float spawnRangeY = 20;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomRock", 2 , 4.0f);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomRock()
    {
        Vector3 position = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY , 0);
        if(PlayerControllerScript.gameOver == false)
        {
            Instantiate(ObstaclePrefabs, position , ObstaclePrefabs.transform.rotation );
        }

    }
    
}
