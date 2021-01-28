using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public GameObject tutorial_text;
    // Start is called before the first frame update
    void Start()
    {
        tutorial_text.SetActive(false);
    }


    public void OnTriggerEnter(Collider other)
    {
        tutorial_text.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        tutorial_text.SetActive(false);
    }
}
