using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public Button btn;
    public GameObject option;

    void Start()
    {
        if (btn == null) btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        option.SetActive(!option.activeSelf);
    }
}
