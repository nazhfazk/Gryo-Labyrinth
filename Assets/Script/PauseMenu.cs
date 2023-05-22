using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButton;

    public void Pause()
    {
        pauseButton.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        pauseButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LevelSelector()
    {
        SceneManager.LoadScene("Level Selector");
    }

    public void Restart1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
    public void Restart2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }
    public void Restart3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
    }
    public void Restart4()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 4");
    }
}
