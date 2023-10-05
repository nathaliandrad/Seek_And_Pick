using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigi;
    private Transform cam;
    private Vector3 movement;
    private float verti, hori, speed;
    private float mouseVerti, mouseHori, mouseSpeedHori, mouseSpeedVerti;

    public AudioSource speaker;
    public AudioClip jumpSound;

    public GameObject[] healthIcons;

    private void Start()
    {
        InitializeVariables();
        InitializeHealthIcons();
    }

    private void Update()
    {
        if (!PauseMenu.isGamePaused)
        {
            HandleInput();
            HandleMouseInput();
        }
        PlayerJumpMovement();
    }

    private void InitializeVariables()
    {
        GM.jumpCount = GM.maxJump;
        rigi = GetComponent<Rigidbody>();
        cam = Camera.main.transform;
        speed = 6;
        mouseSpeedHori = 3;
        mouseSpeedVerti = 2;
    }

    private void InitializeHealthIcons()
    {
        foreach (var icon in healthIcons)
        {
            icon.SetActive(true);
        }
    }

    private void HandleInput()
    {
        verti = Input.GetAxis("Vertical");
        hori = Input.GetAxis("Horizontal");
        movement.x = hori * speed;
        movement.y = rigi.velocity.y;
        movement.z = verti * speed;
        rigi.velocity = transform.TransformDirection(movement);
    }

    private void HandleMouseInput()
    {
        mouseVerti = Input.GetAxis("Mouse Y");
        mouseHori = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, mouseHori * mouseSpeedHori, 0));
        cam.Rotate(new Vector3(-mouseVerti * mouseSpeedVerti, 0, 0));
    }

    private void PlayerJumpMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GM.jumpCount > 0)
        {
            PlayerJump();
        }
    }

    private void PlayerJump()
    {
        speaker.PlayOneShot(jumpSound, 0.9f);
        GM.jumpCount -= 1;
        rigi.AddRelativeForce(new Vector3(0, 600, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GM.health -= 1;
        }
        else if (collision.gameObject.CompareTag("Land"))
        {
            GM.jumpCount = GM.maxJump;
        }
    }

    private void UpdateHealthIcons()
    {
        for (int i = 0; i < healthIcons.Length; i++)
        {
            healthIcons[i].SetActive(i < GM.health);
        }
    }
}
