using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dialoguePortrait;
    public GameObject dialogueBox;
    public Text dialogueText;

    public bool dialogueActive;

    public string[] dialogue;

    void Start()
    {
        
    }

    void Update()
    {
        if (dialogueActive && Input.GetKeyUp(KeyCode.Space))
        {
            dialogueBox.SetActive(false);
            dialoguePortrait.SetActive(false);
            dialogueActive = false;
        }
    }

    public void DialogueDisplayed(string dialogue)
    {
        dialogueActive = true;
        dialogueBox.SetActive(true);
        dialoguePortrait.SetActive(true);
        dialogueText.text = dialogue;
    }
}
