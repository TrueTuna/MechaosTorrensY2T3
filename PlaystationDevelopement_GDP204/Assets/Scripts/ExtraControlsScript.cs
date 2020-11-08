using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraControlsScript : MonoBehaviour
{

    private bool gamePaused;
    private float currentTimeScale;
    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
        currentTimeScale = 1.0f; // assuming normal runtime to start 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                gamePaused = false;
                Time.timeScale = currentTimeScale;
            }
            else
            {
                gamePaused = true;
                currentTimeScale = Time.timeScale;
                Time.timeScale = 0.0f;
            }
        }
    }
}
