using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;
    public GameObject dialogueBox;
    private Movement movement;
    void Start()
    {
        sentences = new Queue<string>();
        dialogueBox.SetActive(false);
        movement = FindObjectOfType<Movement>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        movement.canMove = false;
        dialogueBox.SetActive(true);
        Debug.Log("Starting conversation");
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (var sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextLine();
        
        
    }

    public void DisplayNextLine()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        var sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        movement.canMove = true;
        Debug.Log("End");
        dialogueBox.SetActive(false);
    }
}
