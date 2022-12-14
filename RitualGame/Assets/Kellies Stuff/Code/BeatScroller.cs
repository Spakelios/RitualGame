using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;

    public  bool hasStarted = true;

    private void Start()
    {
        beatTempo = beatTempo / 30f; //originally 60f
    }

    private void Update()
    {
        if (hasStarted)
        {
            {
                transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            }
        }
    }
}