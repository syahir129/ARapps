using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public Button playButton;
    

    void Start()
    {
        playButton.onClick.AddListener(ToggleAudio);
    }

    void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }

    }


}
