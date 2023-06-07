using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueHandler : MonoBehaviour
{
    private GameObject pauseMenue;
    public GameObject Options;

    private void Awake()
    {
        if (!GameObject.Find("Pausescreen"))
        {
            return;
        }

        pauseMenue = GameObject.Find("Pausescreen");
        pauseMenue.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenue.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OptionClick()
    {
        pauseMenue.SetActive(false);
        Options.SetActive(true);
    }

    public void Back()
    {
        pauseMenue.SetActive(true);
        Options.SetActive(false);
    }

    public void Resume()
    {
        pauseMenue.SetActive(false);
    }

    public void Leave()
    {
        SceneManager.LoadScene("MainMenue");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
