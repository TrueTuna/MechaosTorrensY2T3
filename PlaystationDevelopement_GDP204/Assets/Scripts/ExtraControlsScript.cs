using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraControlsScript : MonoBehaviour
{

    private bool gamePaused;
    private float currentTimeScale;

    public GameObject pauseScreen;
    private EndGame endGame;

    // Start is called before the first frame update
    
    void Start()
    {
        gamePaused = false;
        currentTimeScale = 1.0f; // assuming normal runtime to start 
        pauseScreen.SetActive(false);
        endGame = gameObject.GetComponent<EndGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && endGame.hasGameEnded != true)
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
    }
}
