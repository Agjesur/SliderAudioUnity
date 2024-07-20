using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Uİsound : MonoBehaviour
{
    public Text volumetext;
    public Slider slider;
    public void SetAudio(float value) 
    {
        AudioListener.volume = value;
        volumetext.text = ((int)(value * 100)).ToString();
        SaveAudio();
    }
    private void Start()
    {
        LoadVolume();
    }
    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("Audio volume", AudioListener.volume);


    }

    private void LoadVolume()
    {
        if (PlayerPrefs.HasKey("Audio volume"))

        {
            AudioListener.volume = PlayerPrefs.GetFloat("Audio volume");
            slider.value = PlayerPrefs.GetFloat("Audio volume");
        }
        else
        {
            PlayerPrefs.SetFloat("Audio volume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("Audio volume");
            slider.value = PlayerPrefs.GetFloat("Audio volume");

        }
    }



}
