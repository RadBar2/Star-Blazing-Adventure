using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public GameObject Portal;
    public TMP_Text scoreText;
    public int score = 0;

    public void Start()
    {
        // Portal = GetComponent<GameObject>();
    }

    public void Update()
    {
        if (score >= 10) Portal.SetActive(true);
    }
}
