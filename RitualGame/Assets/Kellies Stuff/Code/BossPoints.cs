using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;


public class BossPoints : MonoBehaviour
{

    public GameObject goodEffect, perfectEffect, missedEffect;
    private bool good, bad, perfect;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Button")) 
        {
            good = true;
            perfect = false;
            bad = false;
        }
        if (other.CompareTag("Button"))
        {
            perfect = true;
            good = false;
            bad = false;
        }
        if (other.CompareTag("MISSED"))
        {
            bad = true;
            perfect = false;
            good = false;
        }
    }

    private void Update()
    {

        if (good && !bad && !perfect)
        {
            Debug.Log("hit");
         
            Destroy(gameObject);
            Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
        }
        if (perfect && !good && !bad)
        {
            Debug.Log("perfect!");
            Destroy(gameObject);
       
            Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
        }
        if (bad && !good && !perfect)
        {
            Debug.Log("bad");
            
            Destroy(gameObject);
            Instantiate(missedEffect, transform.position, missedEffect.transform.rotation);
               
        }

    }
}
