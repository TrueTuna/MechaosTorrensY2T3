using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class MenuNewInputs : MonoBehaviour
{
    PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Menu.Play.performed += context => PlayGame();
    }

    void PlayGame()
    {
        SceneManager.LoadScene(1);
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
