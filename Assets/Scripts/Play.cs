using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Button btn;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        audio.PlayOneShot(audio.clip);
        SceneManager.LoadScene("SampleScene");
    }
}
