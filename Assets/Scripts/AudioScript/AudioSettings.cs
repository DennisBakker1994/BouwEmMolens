using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [Header("Audio Mixer")]
    [SerializeField] private AudioMixer audioMixer;

    [Header("Main Menu")]
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    [Header("In Game")]
    [SerializeField] private Slider masterSliderIG;
    [SerializeField] private Slider musicSliderIG;
    [SerializeField] private Slider sfxSliderIG;

    [Header("Object")]
    [SerializeField] private GameObject mainMenu;

    private bool mMToBM;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            LoadMaster();
        }
        else
        {
            SetMasterVolume();
        }

        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            LoadMusic();
        }
        else
        {
            SetMusicVolume();
        }

        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            LoadSFX();
        }
        else
        {
            SetSFXVolume();
        }

    }

    private void Update()
    {
        CheckMenuSwitch();
    }

    void CheckMenuSwitch() 
    {
        if (mainMenu.activeInHierarchy == false)
        {
            if (!mMToBM)
            {
                masterSliderIG.value = PlayerPrefs.GetFloat("MasterVolume");
                musicSliderIG.value = PlayerPrefs.GetFloat("MusicVolume");
                sfxSliderIG.value = PlayerPrefs.GetFloat("SFXVolume");
                mMToBM = true;
            }

        }
    }

    public void SetMasterVolume()
    {
        if(mainMenu.activeInHierarchy == true)
        {
            float volumeMaster = masterSlider.value;

            audioMixer.SetFloat("MasterP", Mathf.Log10(volumeMaster) * 20);

            PlayerPrefs.SetFloat("MasterVolume", volumeMaster);
        }
        else
        {
                float volumeMaster = masterSliderIG.value;

                audioMixer.SetFloat("MasterP", Mathf.Log10(volumeMaster) * 20);

                PlayerPrefs.SetFloat("MasterVolume", volumeMaster);
        }

    }

    public void SetMusicVolume()
    {
        if (mainMenu.activeInHierarchy == true)
        {
            float volumeMusic = musicSliderIG.value;

            audioMixer.SetFloat("MusicP", Mathf.Log10(volumeMusic) * 20);

            PlayerPrefs.SetFloat("MusicVolume", volumeMusic);
        }
        else
        {
                float volumeMusic = musicSliderIG.value;

                audioMixer.SetFloat("MusicP", Mathf.Log10(volumeMusic) * 20);

                PlayerPrefs.SetFloat("MusicVolume", volumeMusic);
        }
    }

    public void SetSFXVolume()
    {
        if (mainMenu.activeInHierarchy == true)
        {
            float volumeSfx = sfxSlider.value;

            audioMixer.SetFloat("SfxP", Mathf.Log10(volumeSfx) * 20);

            PlayerPrefs.SetFloat("SFXVolume", volumeSfx);
        }
        else 
        {
                float volumeSfx = sfxSlider.value;

                audioMixer.SetFloat("SfxP", Mathf.Log10(volumeSfx) * 20);

                PlayerPrefs.SetFloat("SFXVolume", volumeSfx);
        }
    }

    private void LoadMaster()
    {
        masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        masterSliderIG.value = PlayerPrefs.GetFloat("MasterVolume");

        SetMasterVolume();
    }

    private void LoadMusic()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        musicSliderIG.value = PlayerPrefs.GetFloat("MusicVolume");

        SetMusicVolume();
    }

    private void LoadSFX()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        sfxSliderIG.value = PlayerPrefs.GetFloat("SFXVolume");

        SetSFXVolume();
    }
}
