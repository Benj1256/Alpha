using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour {

    private Rigidbody PlayerRb;
    //public ParticleSystem explosiveParticle;
   // public ParticleSystem LightingParticle; (lighting effect)
   // public float Gravity; use when collide
    public AudioClip crashSound;
    private AudioSource audio;
    public bool gameOver = true;
    public float speed = 80.0f;
    private GameObject camera;
    private bool PowerUp;
    public GameObject title;
    //private Animator playerAnim; (use later for thor)

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        PlayerRb = GetComponent<Rigidbody>();
        camera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()

    {
       float op = Input.GetAxis("Vertical");

        if (op != 0 && !gameOver)
        {
            PlayerRb.AddForce(camera.transform.up  * speed * op);
        }

       /* if (Input.GetKey(KeyCode.W) && !gameOver)
        {
            PlayerRb.AddForce(Vector3.up * speed); 
             
        }
        else if(Input.GetKey(KeyCode.S) && !gameOver)
        {
            PlayerRb.AddForce(Vector3.down * speed);
        }*/

        PlayerRb.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            PlayerRb.useGravity = true;
            gameOver = true;
            Debug.Log("Game Over");
            audio.PlayOneShot(crashSound);
            //explosiveParticle.Play();
        }

        else if (collision.gameObject.CompareTag("Goal")){
            PlayerRb.useGravity = true;
            gameOver = true;
            Debug.Log("Congrats");

        }
        
     }


    private void OnTriggerEnter(Collider collision) { 
     if(collision.gameObject.CompareTag("PowerUp"))
        {
            PowerUp = true;
            Destroy(collision.gameObject);
        }
    }

    public void StartGame()
    {
        gameOver = false;
        title.gameObject.SetActive(false);
        
        // Physics.gravity *= Gravity; (Use when collides to fall)
        //playerAnim = GetComponent<Animator>();

    }
}
