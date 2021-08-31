using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableText : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas theCanvaas;
    public Text displayText;
    public string[] objectsText;
    private bool isActive;
    private bool playerInArea = false;
    private int index = 0;
    void Start()
    {
        theCanvaas.gameObject.SetActive(false);
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
      

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown("q"))
        {
            
            if (!isActive) { 
                
                    Debug.Log("open");
                    theCanvaas.gameObject.SetActive(true);
                    displayText.text = objectsText[index];
                    isActive = true;
                

            }
            else
            {
                index++;
                Debug.Log("what the index: " + index);
                Debug.Log("what the lenght: " + objectsText.Length);
                if (index < objectsText.Length)
                {
                    displayText.text = objectsText[index];
                }
                else
                {
                    Debug.Log("close");
                    theCanvaas.gameObject.SetActive(false);
                    displayText.text = "";
                    isActive = false;
                    index = 0;

                }
                   
                
            }

        }

    }
}



