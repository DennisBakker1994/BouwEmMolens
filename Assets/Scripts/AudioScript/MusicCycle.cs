using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicCycle : MonoBehaviour
{
    public AudioClip song1;
    public AudioClip song2;
    public AudioClip song3;
    public AudioClip song4;
    public AudioSource source;

    int songI;
    private void Update()
    {
       if (!source.isPlaying)
        {
            songI = Random.Range(1, 5);

            ChangeSong();

        }
    }

    void ChangeSong()
    {
        if(songI == 1)
        {
            source.clip = song1;
            source.Play();
        }
        if(songI == 2) 
        {
            source.clip = song2;
            source.Play();
        }
        if (songI == 3)
        {
            source.clip = song3;
            source.Play();
        }
        if (songI == 4)
        {
            source.clip = song4;
            source.Play();
        }
    }
}
