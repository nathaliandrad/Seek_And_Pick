using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isGamePaused = false;
    public GameObject pauseMenuOnCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuOnCanvas.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    void PauseGame()
    {
        pauseMenuOnCanvas.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitGameFromPausedMenu()
    {
        Application.Quit();
    }
}
