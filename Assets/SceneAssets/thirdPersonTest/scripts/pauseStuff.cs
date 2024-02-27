using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using TMPro;

public class pauseStuff : MonoBehaviour
{
    public GameObject pauseScr;
    public Button settingsButton;

    private bool isPaused = false;

    private void Start()
    {
        pauseScr.SetActive(false);
    }

    void OnPause () {
        PauseGame();
    }

    public void PauseGame ()
    {
        if (isPaused)
        {
            Debug.Log("UnPaused");
            isPaused = false;
            Time.timeScale = 1;
            pauseScr.SetActive(false);
        }
        else
        {
            Debug.Log("Paused");
            isPaused = true;
            Time.timeScale = 0;
            pauseScr.SetActive(true);
        }
    }
}
