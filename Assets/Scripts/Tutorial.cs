using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public GameObject spawner;
    public TextMeshProUGUI score;
    public TextMeshProUGUI tutorialText;
    public GameObject example;
    bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "Move using";
    }

    // Update is called once per frame
    void Update()
    {
        LoadExample();
    }

    void LoadExample()
    {
        if (Input.GetKeyDown(KeyCode.W) && !activated)
        {
            example.SetActive(false);

            tutorialText.text = "Use space to shoot";
            if (Input.GetKeyUp(KeyCode.Space) && !activated)
            { 
                activated = true;
                spawner.SetActive(true);
                tutorialText.text = $"";

                if (score.text == "Asteroids Destroyed: 10/10")
                {
                    spawner.SetActive(false);
                }

            }
        }
        else return;
        

    }
}
