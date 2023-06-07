using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    private int score;
    private GameObject winscreen;
    private AudioSource winSoundAudioSource;
    private bool winOnce;
    

    private void Awake()
    {
        winscreen = GameObject.Find("Winscreen");
        winSoundAudioSource = GameObject.Find("Win").GetComponent<AudioSource>();

        winscreen.SetActive(false);
    }

    private void Update()
    {
        if (score >= 8 && !winOnce)
        {
            winOnce = true;
            Debug.Log("Win");

            winSoundAudioSource.Play();

            winscreen.SetActive(true);
        }
    }

    public void AddScore()
    {
        score++;
    }
}
