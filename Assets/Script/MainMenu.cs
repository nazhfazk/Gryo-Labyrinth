using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Info()
    {
        SceneManager.LoadScene("Info");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
