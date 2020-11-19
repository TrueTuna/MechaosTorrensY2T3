using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public bool hasGameEnded;
    public GameObject winScreen;
    public GameObject loseScreen;


    // various win/lose conditions
    public WaveSpawner waveSpawner;
    public PlayerHealthEnergy playerHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        hasGameEnded = false;
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGameEnded == false)
        {
            // player win - survived all waves
            if(waveSpawner.currentWave > waveSpawner.totalWaves)
            {
                hasGameEnded = true;
                Time.timeScale = 0.0f;
                winScreen.SetActive(true);
            }

            // player lose - out of health;
            if (playerHealthScript.health <= 0)
            {
                hasGameEnded = true;
                Time.timeScale = 0.0f;
                loseScreen.SetActive(true);
            }
        }

    }
}
