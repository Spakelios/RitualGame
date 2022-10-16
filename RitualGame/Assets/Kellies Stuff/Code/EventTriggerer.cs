using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EventTriggerer : MonoBehaviour
{
    public TextMeshProUGUI speak, talk,shout;
   //neph
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
        speak.text = "Where we dropping, boy?";
    }

    public void oh()
    {
        speak.text = "Oh You want some one on one time with me?";
    }
    
    
// bast
    public void meow()
    {
        talk.text = "Bored already? Least get me something good while you're out.";
    }

    public void meow2()
    {
        talk.text = "Another one? I don't remember agreeing to that.";
    }

    public void meow3()
    {
        talk.text = "You know, like nya?";
    }

    public void Meow4()
    {
        talk.text = "Oh thats more like it. Whats Wrong? Cat got your tongue?";
    }
    
    //amon
    public void sheep()
    {
        shout.text = "Good Riddance, Don't come back!";
    }

    public void sheep2()
    {
        shout.text = "A fraud like you would need more than one.";
    }

    public void sheep3()
    {
        shout.text = "What do you want?";
    }

    public void sheep4()
    {
        shout.text = "Took you long enough..";
    }
    
    
}
