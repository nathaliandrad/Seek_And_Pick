using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockRound : MonoBehaviour
{
    public Light lightRound;
    public AudioSource speaker;
    public AudioClip gotRightItemSound;
    // Update is called once per frame
    void Start()
    {
        Locked();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Round Item aqquired");
            Unlocked();
            GM.round = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Locked();
            GM.round = false;
        }
    }

    public void Unlocked()
    {
        speaker.PlayOneShot(gotRightItemSound, 1);
        lightRound.color = Color.green;
    }

    public void Locked()
    {
        lightRound.color = Color.red;
    }

}
