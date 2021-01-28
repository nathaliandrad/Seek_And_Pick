using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMG : MonoBehaviour
{
    public Text ui_Timer;
    public float totalTime;

    float minutes;
    float seconds;

    public GameObject player_script;
    public GameObject endgameObject;

    public void Update()
    {
   
        totalTime -= Time.deltaTime;

        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);

        ui_Timer.text = minutes.ToString() + " : " + seconds.ToString();
        if (totalTime <= 0)
        {
            if (GM.health < 1)
            {
                StartCoroutine("EndGame");
              
            }

            Restart();
        }
    }

    public void Restart()
    {
        if(GM.health < 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            GM.health -= 1;
            player_script.SendMessage("SettingHealth");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

   IEnumerator EndGame()
    {
        endgameObject.SetActive(true);
        yield return new WaitForSeconds(20);
        
    }



}
