using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

  public class Campfire : MonoBehaviour
  {

    public GameObject DialoguePanel;
    public TMP_Text dialoguetext;
    private int index;
    public float wordspeed;
    public bool playerIsClose;
    public string[] dialogue;

    public void OnTriggerEnter2D(Collider2D collider2D) {
        print("Entered..");
        if (collider2D.CompareTag("Player")) {
            playerIsClose = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collider2D) {
        if (collider2D.CompareTag("Player")) {
            playerIsClose = false;
            zeroText();
        }
    }

    void Update(){
        if (playerIsClose)
        {
            if (DialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                DialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (dialoguetext.text == dialogue[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialoguetext.text = dialogue[index];
            }
        }

    }



    IEnumerator Typing()
    {

        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(wordspeed);
        }

    }

    public void NextLine()
    {

        if(index < dialogue.Length - 1)
        {
            index++;
            dialoguetext.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }

    }

    public void zeroText()
    {
        dialoguetext.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
    }
    

    // Update is called once per frame
   

    

 }
