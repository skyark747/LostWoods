using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class QuitWindow : MonoBehaviour
{
    public GameObject panel;
    public void click()
    {
        panel.SetActive(true);
        AudioListener.volume = 0;
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        panel.SetActive(false);
        AudioListener.volume = 1.0f;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AudioListener.volume = 1.0f;
        Time.timeScale = 1f;
    }

}
