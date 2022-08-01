using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeLevel : MonoBehaviour
{
    public Slider Slider;
    public string whatValue;


    void Start()
    {
        Slider = GetComponent<Slider>();
        Slider.value = PlayerPrefs.GetFloat(whatValue, 75);
        SetSpecificVolume();
    }

    public void SetSpecificVolume()
    {
        if (whatValue == "main")
        {
            AkSoundEngine.SetRTPCValue("MainVolume", Slider.value);
            PlayerPrefs.SetFloat("main", Slider.value);
        }
        else if (whatValue == "music")
        {
            AkSoundEngine.SetRTPCValue("MusicVolume", Slider.value);
            PlayerPrefs.SetFloat("music", Slider.value);
        }
        else if (whatValue == "sfx")
        {
            AkSoundEngine.SetRTPCValue("SFXVolume", Slider.value);
            PlayerPrefs.SetFloat("sfx", Slider.value);
        }
    }
}
