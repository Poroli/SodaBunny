using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    private int score;

    private GameObject winscreen;

    private void Awake()
    {
        winscreen = GameObject.Find("Winscreen");

        winscreen.SetActive(false);
    }

    private void Update()
    {
        if (score >= 8)
        {
            Debug.Log("Win");
            winscreen.SetActive(true);
        }
    }

    public void AddScore()
    {
        score++;
    }
}
