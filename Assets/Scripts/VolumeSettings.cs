using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioSource audio;
    public Slider slider;

    public void Update()
    {
        audio.volume = slider.value;
    }
}
