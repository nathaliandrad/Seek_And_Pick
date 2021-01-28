using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSquare : MonoBehaviour
{
    public Light lightSquare;
    public AudioSource speaker;
    public AudioClip gotRightItemSound;

    public void Start()
    {
        Locked();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            Debug.Log("Square Item aqquired");
            Unlocked();
            GM.square = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Locked();
            GM.square = true;
        }
    }

    public void Unlocked()
    {
        speaker.PlayOneShot(gotRightItemSound, 1);
        lightSquare.color = Color.green;
    }

    public void Locked()
    {
        lightSquare.color = Color.red;
    }

}
