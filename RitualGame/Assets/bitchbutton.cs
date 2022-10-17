using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitchbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            InfoStorage.DemonUnlock1++;
        }
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            InfoStorage.DemonUnlock2++;
        }
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            InfoStorage.DemonUnlock3++;
        }
    }
}
