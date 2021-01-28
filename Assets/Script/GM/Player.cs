using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigi;
    Vector3 movement;
    Transform cam;
    float verti, hori, speed;
    float mouseVerti, mouseHori, mouseSpeedHori, mouseSpeedVerti;

    public AudioSource speaker;
    public AudioClip jumpSound;

    public GameObject h1, h2, h3, h4, h5;

    void Start()
    {
        GM.jumpCount = GM.maxJump;
        //health = 5;
        //GM.health = 5;
        GM.jumpCount = GM.maxJump;
        rigi = GetComponent<Rigidbody>();
        cam  = Camera.main.transform;
        
        speed      = 6;
        mouseSpeedHori = 3;
        mouseSpeedVerti = 2;
    }

    // Update is called once per frame
    void Update()
    {
       
        SettingHealth();
        //keyboard input
        verti = Input.GetAxis("Vertical");
        hori  = Input.GetAxis("Horizontal");
        //setting movement
        movement.x = hori * speed;
        movement.y = rigi.velocity.y;
        movement.z = verti * speed;
        //mouse input
        mouseVerti = Input.GetAxis("Mouse Y");
        mouseHori  = Input.GetAxis("Mouse X");
  
        rigi.velocity = transform.TransformDirection(movement);
        if (!PauseMenu.isGamePaused)
        {
            transform.Rotate(new Vector3(0, mouseHori * mouseSpeedHori, 0));
            cam.Rotate(new Vector3(-mouseVerti * mouseSpeedVerti, 0, 0));
        }
        PlayerJumpMovement();

    }
    public void PlayerJumpMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GM.jumpCount > 0)
            {
                PlayerJump();
            }
        }
    }

    void PlayerJump()
    {
        speaker.PlayOneShot(jumpSound, 0.9f);
        GM.jumpCount -= 1;
        rigi.AddRelativeForce(new Vector3(0, 600, 0));
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GM.health -= 1;
        }
        if (collision.gameObject.CompareTag("Land"))
        {
            GM.jumpCount = GM.maxJump;
        }
    }


    public void SettingHealth()
    {
        if (GM.health == 5)
        {
            h5.SetActive(true);
            h4.SetActive(true);
            h3.SetActive(true);
            h2.SetActive(true);
            h1.SetActive(true);
        }
        if(GM.health == 4)
        {
            h5.SetActive(false);
            h4.SetActive(true);
            h3.SetActive(true);
            h2.SetActive(true);
            h1.SetActive(true);
        }
        if (GM.health == 3)
        {
            h5.SetActive(false);
            h4.SetActive(false);
            h3.SetActive(true);
            h2.SetActive(true);
            h1.SetActive(true);
        }
        if(GM.health == 2)
        {
            h5.SetActive(false);
            h4.SetActive(false);
            h3.SetActive(false);
            h2.SetActive(true);
            h1.SetActive(true);
        }
        if (GM.health == 1)
        {
            h5.SetActive(false);
            h4.SetActive(false);
            h3.SetActive(false);
            h2.SetActive(false);
            h1.SetActive(true);
        }
        if (GM.health == 0)
        {
            h5.SetActive(false);
            h4.SetActive(false);
            h3.SetActive(false);
            h2.SetActive(false);
            h1.SetActive(false);
        }

    }


}
