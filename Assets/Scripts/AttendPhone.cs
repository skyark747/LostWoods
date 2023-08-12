using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendPhone : MonoBehaviour
{
    public AudioSource audsrc;
    public Button btn;
    public void stopsound()
    {
        audsrc.Stop();
        btn.enabled = false;
    }
}
