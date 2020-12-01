using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class MenuNewInputs : MonoBehaviour
{
    PlayerControls controls;
    private bool controlToggle;
    public GameObject controlScreen;
    public GameObject mainScreen;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Menu.Play1.performed += context => PlayGame1();
        controls.Menu.Play2.performed += context => PlayGame2();
        controls.Menu.Play3.performed += context => PlayGame3();
        controls.Menu.Controls.performed += context => ControlsToggle();
        controlToggle = false;

    }

    void PlayGame1()
    {
        SceneManager.LoadScene(1);
    }

    void PlayGame2()
    {
        SceneManager.LoadScene(2);
    }

    void PlayGame3()
    {
        SceneManager.LoadScene(3);
    }

    void ControlsToggle()
    {
        if (controlToggle)
        {
            controlToggle = false;
            controlScreen.SetActive(false);
            mainScreen.SetActive(true);
        }
        else
        {
            controlToggle = true;
            controlScreen.SetActive(true);
            mainScreen.SetActive(false);
        }
    }

    void OnEnable()
    {
        controls.Menu.Enable();
    }

    void OnDisable()
    {
        controls.Menu.Disable();
    }
}
