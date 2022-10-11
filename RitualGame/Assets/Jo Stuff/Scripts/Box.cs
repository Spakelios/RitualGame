using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject sheetMusic;
    private int[] solution = {5, 7, 2, 4, 6};
    private ButtonPuzzle firstNumber;
    private ButtonPuzzle secondNumber;
    private ButtonPuzzle thirdNumber;
    private ButtonPuzzle fourthNumber;
    private ButtonPuzzle fifthNumber;

    private void Start()
    {
        sheetMusic.SetActive(false);
        firstNumber = GameObject.Find("Button (1)").GetComponent<ButtonPuzzle>();
        secondNumber = GameObject.Find("Button (2)").GetComponent<ButtonPuzzle>();
        thirdNumber = GameObject.Find("Button (3)").GetComponent<ButtonPuzzle>();
        fourthNumber = GameObject.Find("Button (4)").GetComponent<ButtonPuzzle>();
        fifthNumber = GameObject.Find("Button (5)").GetComponent<ButtonPuzzle>();
    }

    private void FixedUpdate()
    {
        if (firstNumber.currentNumber == solution[0] && secondNumber.currentNumber == solution[1] &&
            thirdNumber.currentNumber == solution[2] && fourthNumber.currentNumber == solution[3] &&
            fifthNumber.currentNumber == solution[4])
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        sheetMusic.SetActive(true);
        Destroy(gameObject);
    }
}
