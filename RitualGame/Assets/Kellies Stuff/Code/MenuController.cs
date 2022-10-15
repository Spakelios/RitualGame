using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject Sprite, Sprite3, Sprite2, box;
    public Button demon1, demon2, demon3;
    public Image sprites;

    public void Update()
    {
        if (InfoStorage.DemonUnlock1 >= 1)
        {
            demon1.interactable = true;
        } 
        if (InfoStorage.DemonUnlock2 >= 1)
        {
            demon2.interactable = true;
        } 
        if (InfoStorage.DemonUnlock3 >= 1)
        {
            demon3.interactable = true;
        }
    }

    public void Swap()
    {
        if (InfoStorage.DemonUnlock1 >= 1)
        {
            Sprite.SetActive(true);
            Sprite2.SetActive(false);
            Sprite3.SetActive(false);
            box.SetActive(false);
        }
    }

    public void Swap2()
    {
        if (InfoStorage.DemonUnlock2 >= 1 )
        {
            Sprite.SetActive(false);
            Sprite2.SetActive(true);
            Sprite3.SetActive(false);
            box.SetActive(false);
        }
    } 
    public void Swap3()
    {
        if (InfoStorage.DemonUnlock3 >= 1 )
        {
            Sprite.SetActive(false);
            Sprite2.SetActive(false);
            Sprite3.SetActive(true);
            box.SetActive(false);
        }
    }

    public void Meow()
    {
        sprites.color = Color.white;
    }

    public void woof()
    {
        sprites.color = Color.black;
    }
}
