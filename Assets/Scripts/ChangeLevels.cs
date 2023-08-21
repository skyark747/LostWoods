using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevels : MonoBehaviour
{
   public void changeScene_1()
    {
        SceneManager.LoadScene("MoodyNight");
    }
    public void changeScene_2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void changeScene_3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void changeScene_4()
    {
        SceneManager.LoadScene("Level 4");
    }

}
