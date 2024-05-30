using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button btn;
    public GameObject menu;

    void Start()
    {
        if (btn == null) btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
