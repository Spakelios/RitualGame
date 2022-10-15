using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TELEPORT : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        InfoStorage.amon++;
       SceneManager.LoadScene("menusss");
    }
}
