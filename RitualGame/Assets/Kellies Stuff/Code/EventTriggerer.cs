using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EventTriggerer : MonoBehaviour
{
    public TextMeshProUGUI speak, talk,shout;
   
    public void Mice()
    {
        speak.text = "Looking for more? All for me i hope! or there may be trouble..";
    }

    public void Mouse()
    {
        speak.text = "Ohhh you wanna summon someone new? Not enough for you am i?";
    }

    public void mouseExit()
    {
        talk.text = "Where we dropping, boy?";
    }
// bast
    public void meow()
    {
        talk.text = "Bored already? Least get me something good while you're out";
    }

    public void meow2()
    {
        talk.text = "Another one? I don't remember agreeing to that";
    }

    public void meow3()
    {
        talk.text = "You know, like nya?";
    } 
    
    //amon
    public void sheep()
    {
        shout.text = "Good Riddance, Don't come back!";
    }

    public void sheep2()
    {
        shout.text = "A fraud like you would need more than one";
    }

    public void sheep3()
    {
        shout.text = "Fuck off";
    } 
    
    
}
