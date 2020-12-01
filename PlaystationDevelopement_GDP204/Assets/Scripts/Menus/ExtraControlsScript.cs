﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ExtraControlsScript : MonoBehaviour
{

    private bool gamePaused;
    private float currentTimeScale;

    public GameObject pauseScreen;
    private EndGame endGame;

    PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.InGame.Enable();
        controls.InGame.Pause.performed += context => PauseGame();
        controls.InGame.End_PlayAgain.performed += context => End_PlayAgain();
        controls.InGame.End_Menu.performed += context => End_Menu();
        controls.InGame.End_Quit.performed += context => End_Quit();

    }

    void Start()
    {
        gamePaused = false;
        currentTimeScale = 1.0f; // assuming normal runtime to start 
        pauseScreen.SetActive(false);
        endGame = gameObject.GetComponent<EndGame>();
    }

    void PauseGame()
    {
        if (gamePaused)
        {
            gamePaused = false;
            Time.timeScale = currentTimeScale;
            pauseScreen.SetActive(false);
        }
        else
        {
            gamePaused = true;
            currentTimeScale = Time.timeScale;
            Time.timeScale = 0.0f;
            pauseScreen.SetActive(true);
        }
    }

    void End_PlayAgain()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    void End_Menu()
    {
        SceneManager.LoadScene(0);
    }
    void End_Quit()
    {
        Application.Quit();
    }
}
