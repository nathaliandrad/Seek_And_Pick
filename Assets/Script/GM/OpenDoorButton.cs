using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoorButton : MonoBehaviour
{
    public GameObject myButtonLight;
    bool ableToOpenDoor;
    public Light buttonLightColor;
    public Animator doorAnimator;
    public Animator doorRightAnimator;
    int count;
    public GameObject itemManagerScript;
    public GameObject spawnManagerLevel1;
    public GameObject spawnItemManagerLevel2;
    public GameObject camera_button;
    public GameObject camera_door;
    public GameObject key_text;

    public AudioSource speaker;
    public AudioClip openDoorSound;

    public void Start()
    {
        count = 0;
        ableToOpenDoor = false;
        myButtonLight.SetActive(false);
        
    }

    public void Update()
    {
        if(GM.square && GM.sharp && GM.round)
        {
            ableToOpenDoor = true;
            count++;
            if(count == 1)
            {
             if(SceneManager.GetActiveScene().buildIndex == 1)
                {
                    itemManagerScript.SendMessage("SpawnKey");
                    key_text.SetActive(true);
                }
             if(SceneManager.GetActiveScene().buildIndex == 2)
                {
                    spawnManagerLevel1.SendMessage("SpawnKey");
                }
             if (SceneManager.GetActiveScene().buildIndex == 3)
                {
                    spawnItemManagerLevel2.SendMessage("SpawnKey");
                }

                StartCoroutine("EnableButton");
               

            }
            myButtonLight.SetActive(true);
        }
        else
        {
            ableToOpenDoor = false;
            myButtonLight.SetActive(false);
           
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (ableToOpenDoor)
        {
            if (collision.gameObject.CompareTag("Key"))
            {
                StartCoroutine("DoorCameraEnable");
                speaker.PlayOneShot(openDoorSound, 0.5f);
                transform.localPosition = new Vector3(0, 0.01f, 0);
                buttonLightColor.color = Color.cyan;
                doorAnimator.enabled = true;
                doorRightAnimator.enabled = true;
                Destroy(collision.gameObject, 3);
            }
           
        }
        
    }

    public IEnumerator EnableButton()
    {
        count++;
        camera_button.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        myButtonLight.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        camera_button.SetActive(false);
    }

    public IEnumerator DoorCameraEnable()
    {
        yield return new WaitForSeconds(0.5f);
        camera_door.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        camera_door.SetActive(false);

    }


}
