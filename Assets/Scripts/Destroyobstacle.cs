using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyobstacle : MonoBehaviour
{

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
         if (collision.gameObject.CompareTag("BigRock") || collision.gameObject.CompareTag("smallRock") )
        Destroy(gameObject);
        Destroy(collision.gameObject);


    }
}
