using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueStarter : MonoBehaviour
{
    public Messages[] msgs;
    public Actor[] actor;
    public GameObject panel;
    public GameObject img;

    public void Start()
    {   
        FindAnyObjectByType<Conversation>().OpenDialogue(msgs, actor);
    }
    public void UpdateMessage()
    { 
         FindAnyObjectByType<Conversation>().NextMessage();
       
    }
}
[System.Serializable]
public class Messages
{
    public int Actorid;
    public string msg;
}
[System.Serializable]
public class Actor
{
    public string name;
    public Sprite pic;
}