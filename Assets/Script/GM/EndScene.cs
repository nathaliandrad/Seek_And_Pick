using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public AudioSource speaker;
    public AudioClip endSong;

    void Start()
    {
        speaker.PlayOneShot(endSong, 0.8f);
        
    }
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(0);
        }
    }
}
