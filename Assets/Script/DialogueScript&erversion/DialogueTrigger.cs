﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    

    // public void TriggerDialogue()
    //{
    //}
    


    public void OnTriggerEnter(Collider other)
    {
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }


    public void OnTriggerExit(Collider other)
    {
        FindObjectOfType<DialogueManager>().EndDialogue(dialogue);
        
    }

   
}

   

