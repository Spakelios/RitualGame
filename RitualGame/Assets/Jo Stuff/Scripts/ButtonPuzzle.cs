using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPuzzle : MonoBehaviour
{
    public int buttonIndex;
    public TextMeshProUGUI note;
    public int minimumNumber;
    public int maximumNumber;
    public int currentNumber = 1;
    public int correctNumber;

    private bool inRange;
    // Start is called before the first frame update

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            if (currentNumber < maximumNumber)
            {
                currentNumber++;
            }

            else
            {
                currentNumber = minimumNumber;
            }
        }

        switch (currentNumber)
        {
            case 1:
                note.text = "A";
                break;
            case 2:
                note.text = "B";
                break;
            case 3:
                note.text = "C";
                break;
            case 4:
                note.text = "D";
                break;
            case 5:
                note.text = "E";
                break;
            case 6:
                note.text = "F";
                break;
            case 7:
                note.text = "G";
                break;
        }
    }
}
