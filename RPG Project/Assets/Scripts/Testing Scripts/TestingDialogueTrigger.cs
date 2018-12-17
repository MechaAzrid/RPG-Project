using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDialogueTrigger : MonoBehaviour
{
    public TestingDialogue dialogue;
    private TestingDialogueManager testingDialogueManager;

    //public void TriggerDialogue()
    //{
    //    FindObjectOfType<TestingDialogueManager>().StartDialogue(dialogue);
    //}

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(other.gameObject.name == "Testing Character")
            {
                FindObjectOfType<TestingDialogueManager>().StartDialogue(dialogue);

                //testingDialogueManager.DisplayNextSentence();
            }
        }

        //if (other.gameObject.name == "Testing Character")
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        FindObjectOfType<TestingDialogueManager>().StartDialogue(dialogue);

        //    }
        //}

        //if (other.gameObject.name == "Testing Character")
        //{
        //        FindObjectOfType<TestingDialogueManager>().StartDialogue(dialogue);
        //}
    }
}
