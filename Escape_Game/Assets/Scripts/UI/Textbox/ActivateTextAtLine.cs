using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour
{
    public string theText;

    public GameObject goTB;
    private TextboxManager theTextBox;

    public bool requireButtonPress = true;
    public bool waitForPress;

    public bool destroyWhenActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        theTextBox = goTB.GetComponent<TextboxManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitForPress && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("I pressed F");
            ShowDescription();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.name == "Player")
        {
            if (requireButtonPress)
            {
                waitForPress = true;
                return;
            }

            if (!waitForPress)
            {
                ShowDescription();
            }
           
            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }  
    }

   

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            waitForPress = false;
        }
    }

    private void ShowDescription()
    {
        ReloadDescription();
        theTextBox.ReloadScript(theText);
        Debug.Log("calling Enable Box");
        theTextBox.EnableTextbox();
    }

    private void ReloadDescription()
    {
        Interactable i = gameObject.GetComponent<Interactable>();
        if (i.hint != null)
        {
            theText = i.hint.description;
        }
        else if (i.obstacle != null)
        {
            theText = i.obstacle.description;

        }
        else if (i.item != null)
        {
            theText = i.item.name + "\n" + i.item.description;
        }
    }

}
