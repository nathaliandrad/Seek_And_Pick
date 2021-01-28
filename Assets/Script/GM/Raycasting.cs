using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycasting : MonoBehaviour
{
    Transform cam;
    RaycastHit other;
    public Text itemName,itemRes;
    float pushForce, pullForce;
    public Transform viewItem;

    AudioSource speaker;
    public AudioClip pickedItemSound, threwItemSound;

    void Start()
    {
        speaker = GetComponent<AudioSource>();
        cam       = Camera.main.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //excluding 8 and 11 layer
        int layerMask = 1 << 8 | 1 << 11 | 1 << 13;
        // This would cast rays only against colliders in layer 8
        layerMask = ~layerMask;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out other, 10f, layerMask))
        {
            Physics.IgnoreLayerCollision(9, 10);
            if (Input.GetMouseButtonDown(0))
            {
                speaker.PlayOneShot(pickedItemSound, 1);
                GM.isHolding = true;
                other.transform.GetComponent<Rigidbody>().useGravity = false;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = viewItem.position;
                other.transform.rotation = viewItem.rotation;

                other.transform.parent = GameObject.Find("Player").transform;

                
                itemName.text = "Release to drop | Press E to throw";

            }
            if (Input.GetMouseButtonUp(0))
            {
                GM.isHolding = false;
                // Physics.IgnoreLayerCollision(9, 10);
                other.transform.parent = null;
                other.transform.GetComponent<Rigidbody>().useGravity = true;
                other.transform.GetComponent<Rigidbody>().isKinematic = false;
            }
            if (GM.isHolding)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    speaker.PlayOneShot(threwItemSound, 0.8f);
                    GM.isHolding = false;
                    // Physics.IgnoreLayerCollision(9, 10);
                    other.transform.parent = null;
                    other.transform.GetComponent<Rigidbody>().useGravity = true;
                    other.transform.GetComponent<Rigidbody>().isKinematic = false;
                    // other.transform.GetComponent<Rigidbody>().AddForce(cam.forward * pushForce);
                    float power = 300;
                    other.transform.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 200, power));

                }
            }
            if (!GM.isHolding)
            {
                itemName.text = "Click to pick up " + other.transform.gameObject.name;
            }
        }
            else
        {
            itemName.text = "";
            itemRes.text = "";
        }

 
    }

}
