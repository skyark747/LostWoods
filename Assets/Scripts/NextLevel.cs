using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public GameObject sprite;
    public void Nextlevel()
    {
        panel.SetActive(true);
       button.SetActive(true);
        sprite.SetActive(true);
        AudioListener.volume = 0;
        Time.timeScale = 0;
    }
}
