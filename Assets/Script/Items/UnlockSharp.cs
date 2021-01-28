using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSharp : MonoBehaviour
{
    public Light lightSharp;
    public AudioSource speaker;
    public AudioClip gotRightItemSound;

     void Start()
    {
        Locked();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Knife"))
        {
            Debug.Log("Sharp Item aqquired");
            Unlocked();
            GM.sharp = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            Locked();
            GM.sharp = false;
        }
    }

    public void Unlocked()
    {
        speaker.PlayOneShot(gotRightItemSound, 1);
        lightSharp.color = Color.green;
    }

    public void Locked()
    {
        lightSharp.color = Color.red;
    }

}
