using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongBoss : MonoBehaviour
{
    public Animator anim;
    public GameObject poo, you;

    public GameObject perfectEffect, missedEffect; 


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GOOD"))
        {
            InfoStorage.BossPoint++;
            anim.Play("Vanish");
            Debug.Log("hold");
            Invoke("FinishNote", 1f);
        }

        else if (other.CompareTag("MISSED"))
        {
            Debug.Log("miss!");
            InfoStorage.BossPoint--;
            Instantiate(missedEffect, transform.position, perfectEffect.transform.rotation);
            Destroy(poo);
            Destroy(you);

        }
        
    }
    void FinishNote()
    {
        Destroy(gameObject);
    }
}