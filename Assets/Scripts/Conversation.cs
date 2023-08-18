using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public TextMeshProUGUI textline;
    public TextMeshProUGUI Name;
    public RectTransform back;
    public Image img;

    Messages[] c_msg;
    Actor[] c_actor;

    bool isactive = true;

    int activemsg = 0;

    public void OpenDialogue(Messages[] msg, Actor[] act)
    {
        c_msg=msg;
        c_actor = act;
        DisplayMsg();
    }

    private void DisplayMsg()
    {
        Messages message = c_msg[activemsg];
        textline.text = message.msg;

        Actor actor = c_actor[message.Actorid];
        Name.text = actor.name;
        img.sprite = actor.pic;

    }

    public void NextMessage()
    {
        activemsg++;
        if(activemsg < c_msg.Length)
        {
            DisplayMsg();
        }
        else
        {
            isactive = false;
            SceneManager.LoadScene("MoodyNight");
        }
        
    }
    
    
}
