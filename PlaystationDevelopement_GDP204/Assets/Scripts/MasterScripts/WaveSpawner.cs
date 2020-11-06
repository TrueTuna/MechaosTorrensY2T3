using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public int totalWaves = 3;
    public int currentWave;
    public int waveEnemyAmount;
    private float waveSpacer = 5;
    public float waveSpacerTimer = 0;
    //UI
    public GameObject countdownBox;
    public TMPro.TextMeshProUGUI countdown;
    public TMPro.TextMeshProUGUI waveCount;
    // wave lists
    public GameObject[] gruntEnemies;
    public GameObject[] spawnLocations;
    public List<GameObject> SpawnedEnemies;
    // cleanup counter
    public float cleanup;

    void Start()
    {
        waveEnemyAmount = 8;
        cleanup = 0;
        currentWave = 0;
    }

    void Update()
    {
        if (SpawnedEnemies.Count == 0) // only do when there are no people remaining
        {
            if (waveSpacerTimer >= waveSpacer) // if enough time has passed
            {
                for (int i = 0; i < waveEnemyAmount; i++)
                {
                    SpawnedEnemies.Add(
                        Instantiate(
                            gruntEnemies[Random.Range(0, gruntEnemies.Length)], spawnLocations[Random.Range(0, spawnLocations.Length)].transform
                        )
                    );
                }
                // these run once
                waveSpacerTimer = 0;
                waveEnemyAmount += 3;
                currentWave += 1;
            }
            else
            {
                waveSpacerTimer += Time.deltaTime;
            }
            countdownBox.SetActive(true);
            countdown.text = (Mathf.Round((5 - waveSpacerTimer) * 10) / 10) + "s";
        }
        else
        {
            countdownBox.SetActive(false);
        }

        // check every second, every enemy to see if they exist
        if(cleanup > 2)
        {
            for (int i = 0; i < SpawnedEnemies.Count; i++)
            {
                if (SpawnedEnemies[i] == null)
                    SpawnedEnemies.RemoveAt(i);
            }
            cleanup = 0;
        }
        else
        {
            cleanup += Time.deltaTime;
        }


        // wave counter
        waveCount.text = "Wave: " + currentWave + " / " + totalWaves;
    }
}
