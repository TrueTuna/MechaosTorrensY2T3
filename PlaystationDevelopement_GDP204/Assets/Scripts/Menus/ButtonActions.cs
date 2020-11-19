using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonActions : MonoBehaviour
{
    public GameObject main;
    public GameObject instructions;
    public GameObject options;

    void Start()
    {
        main.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }

    public void Instructions()
    {
        main.SetActive(false);
        instructions.SetActive(true);
    }

    public void Options()
    {
        main.SetActive(false);
        options.SetActive(true);
    }

    public void Back()
    {
        main.SetActive(true);
        options.SetActive(false);
        instructions.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
