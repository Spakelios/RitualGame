using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject musicTablet;
    public Movement player;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player") && player.hasKey)
        {
            musicTablet.SetActive(true);
            Destroy(gameObject);
        }
    }
}
