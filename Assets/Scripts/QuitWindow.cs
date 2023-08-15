using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuitWindow : MonoBehaviour
{
    public GameObject panel;
    public void click()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
