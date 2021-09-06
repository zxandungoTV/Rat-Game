using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class InteractableText : MonoBehaviour
{
    // important stuff
    
    public Text displayText;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;

    //not important now
    private bool isActive;
    private bool playerInArea = false;
    public Canvas theCanvaas;

    IEnumerator Type()
    {
        
        foreach(char letter in sentences[index].ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    void Start()
    {
        //StartCoroutine("Type");
        //theCanvaas.gameObject.SetActive(false);
        //isActive = false;
    }
    void Update()
    {
        if(displayText.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            displayText.text = "";
            StartCoroutine("Type");
        }
        else
        {
            displayText.text = "";
            continueButton.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown("q"))
        {
            
            if (!isActive) { 
                
                theCanvaas.gameObject.SetActive(true);
                isActive = true;
                StartCoroutine("Type");

            }
            else
            {
                theCanvaas.gameObject.SetActive(false);
                isActive = false;
                index = 0;

            }

        }

    }
}



