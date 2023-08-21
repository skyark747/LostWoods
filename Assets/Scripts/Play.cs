using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField] GameObject Panel;
    protected bool IsArcade = false;
    public void play()
    {
        SceneManager.LoadScene("StartMovie");
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Arcade()
    {
        if(IsArcade)
        {
            SceneManager.LoadScene("ArcadeMode");
        }
        else
        {
            string str = "Complete Story mode to unlock.";
            text.text = str;
            
        }
    }
    public void panel()
    {
        Panel.SetActive(true);
    }

    public void YTButton()
    {
        Panel.SetActive(false);
    }
}
