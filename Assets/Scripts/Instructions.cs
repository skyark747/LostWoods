using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject panel;

    public void Update()
    {
        AudioListener.volume = 0;
        Time.timeScale = 0f;
    }
    public void ClosePanel()
    {
        panel.SetActive(false);

        AudioListener.volume = 1;
        Time.timeScale = 1f;
    }
}
