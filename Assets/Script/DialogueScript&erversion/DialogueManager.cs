﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;
    private Dialogue dialogue;
   



    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();

     
    }

    public void StartDialogue(Dialogue dialogue)
    {
        
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;


        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
  
    public void DisplayNextSentence()
    {
       
        
            if (sentences.Count == 0)
            {
                EndDialogue(dialogue);
                return;
            }



            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
           
    }
  

    IEnumerator TypeSentence(string sentence)//va chercher les bloc de texte dans le script dialogue trigger des personnages
    {

        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }


    }



    public void EndDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen",false);
    }
   
}


