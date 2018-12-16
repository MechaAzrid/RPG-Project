using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{

    public string dialogue;
    private DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Testing Character")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogueManager.DialogueDisplayed(dialogue);
            }
        }
    }

    void Update()
    {
        
    }
}
