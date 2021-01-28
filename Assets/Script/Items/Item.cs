using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public AudioSource speaker;
    public AudioClip dropSound;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            speaker.PlayOneShot(dropSound, 1f);
        }
    }
}
