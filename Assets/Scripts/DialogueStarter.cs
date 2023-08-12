using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    public Messages[] msgs;
    public Actor[] actor;

    public AudioSource audioSource;
    public void Startsound()
    {
        audioSource.Stop();
        FindAnyObjectByType<Conversation>().OpenDialogue(msgs, actor);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            FindAnyObjectByType<Conversation>().NextMessage();
        }
  
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