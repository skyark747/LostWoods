using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AttendPhone : MonoBehaviour
{
    public AudioSource audsrc;
    public void stopsound()
    {
        audsrc.Stop();
        SceneManager.LoadScene("Dialogues");
    }
}
