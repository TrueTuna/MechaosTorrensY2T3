using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSongPicker : MonoBehaviour
{
    private AudioSource songPlayer;
    public AudioClip menuSong; // for main menu only
    public AudioClip[] TrackList; // for gameplay
    private int trackListInt; // for the array
    public AudioClip currentSong; // which song is selected

    static bool created = false;
    private bool songChangeOver;



    void Start()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
        songPlayer = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0) // if we are on the menu
        {
            if (!songPlayer.isPlaying) // and a song is not playing
            {
                // play menu song
                songPlayer.clip = menuSong;
                songPlayer.Play();
                songChangeOver = true;
            }
        }
        else // if we are on other levels
        {
            if(songChangeOver)
            {
                songPlayer.Stop();
                songChangeOver = false;
            }

            if (!songPlayer.isPlaying) // and song not playing
            {
                // pick song from list
                trackListInt = Random.Range(0, TrackList.Length);
                currentSong = TrackList[trackListInt];

                // check it isnt the same
                while (currentSong == songPlayer.clip)
                {
                    trackListInt = Random.Range(0, TrackList.Length);
                    currentSong = TrackList[trackListInt];
                }

                songPlayer.clip = currentSong;
                songPlayer.Play();
            }
        }
    }
}
