using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;

    private float startTime;
    private float elapsedTime;
    
    void Update()
    {
        elapsedTime = Time.time - startTime;
        timer.text = $"{Mathf.Floor(elapsedTime / 60)}:{Mathf.Floor(elapsedTime % 60)}:{Mathf.Floor((elapsedTime - (int)(elapsedTime))*1000)}";
    }
}

