using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

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
            //SceneManager.LoadScene("ArcadeMode");
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
