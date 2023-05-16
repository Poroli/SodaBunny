using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueHandler : MonoBehaviour
{
    public GameObject PauseMenue;
    public GameObject Options;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenue.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadGame()
    {

    }

    public void OptionClick()
    {
        PauseMenue.SetActive(false);
        Options.SetActive(true);
    }

    public void Back()
    {
        PauseMenue.SetActive(true);
        Options.SetActive(false);
    }

    public void Resume()
    {
        PauseMenue.SetActive(false);
    }

    public void Leave()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
