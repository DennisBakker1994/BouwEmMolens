using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public AudioClip clipClick;
    public AudioClip clipHover;
    public AudioSource audioSource; 
    public void Quit()
    {
        Application.Quit();
    }

    public void ButtonClickSound()
    {
        audioSource.clip = clipClick;
        audioSource.Play();
    }

    public void ButtonHoverSounds()
    {
        audioSource.clip = clipHover;
        audioSource.Play();
    }
}
