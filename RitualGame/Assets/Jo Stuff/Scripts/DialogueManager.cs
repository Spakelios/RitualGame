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
    private AudioManager audioManager;
    public AudioSource talking;

    void Start()
    {
        sentences = new Queue<string>();
        dialogueBox.SetActive(false);
        movement = FindObjectOfType<Movement>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        movement.canMove = false;
        dialogueBox.SetActive(true);
        Debug.Log("Starting conversation");
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
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

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            talking.Play();
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.08f);
        }

        talking.Stop();
    }

    public void EndDialogue()
    {
        movement.canMove = true;
        Debug.Log("End");
        dialogueBox.SetActive(false);
    }
}
