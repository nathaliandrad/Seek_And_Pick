using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_To_Next_Level : MonoBehaviour
{
    int nextScene;

    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GM.sharp = false;
            GM.round = false;
            GM.square = false;

            SceneManager.LoadScene(nextScene);
        }
    }

}
