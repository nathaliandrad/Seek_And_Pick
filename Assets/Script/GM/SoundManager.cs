using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource speaker;
    AudioClip music;
    // Start is called before the first frame update
    void Start()
    {
        speaker = GetComponent<AudioSource>();
        speaker.Play(1);
    }
}
