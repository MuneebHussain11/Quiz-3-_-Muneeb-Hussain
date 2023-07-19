using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 10.0f;
    public bool gameOver = false;

    private Animator playerAnim;

    public GameObject bulletPrefab;

    public ParticleSystem explosionParticle;

    public AudioClip shootSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();

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


        horizontalInput = Input.GetAxis("Horizontal");



       
        if(gameOver != true)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed );
        }
    
            

        if (Input.GetKeyDown(KeyCode.Space) && gameOver != true)
        {
            Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            playerAudio.PlayOneShot(shootSound, 1.0f);

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
    
       if(collision.gameObject.CompareTag("BigRock") || collision.gameObject.CompareTag("smallRock"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }

    }
}



