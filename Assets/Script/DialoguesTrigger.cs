﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguesTrigger : MonoBehaviour
{
    public Dialogues dialogues;
    
    public void TriggerDialogues()
    {
        FindObjectOfType<DialogueManager>().StartDialogues(dialogues);

    }
}