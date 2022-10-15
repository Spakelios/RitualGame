using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EventTriggerer : MonoBehaviour
{
    public TextMeshProUGUI speak;
   
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
}
