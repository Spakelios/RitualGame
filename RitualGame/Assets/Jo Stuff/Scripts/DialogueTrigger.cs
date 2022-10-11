using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool inDialogueRange;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inDialogueRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        inDialogueRange = false;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void Update()
    {

        if (inDialogueRange)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                TriggerDialogue();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueManager>().DisplayNextLine();
            }
        }
    }
}
