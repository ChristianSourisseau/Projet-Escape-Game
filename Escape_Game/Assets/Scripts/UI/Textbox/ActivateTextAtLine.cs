using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour
{
    public TextAsset theText;

    public int startLine;
    public int endLine;

    public TextboxManager theTextBox;

    public bool requireButtonPress;
    public bool waitForPress;

    public bool destroyWhenActivated;


    #region CODE CHRISTIAN SOURISSEAU

    public void Awake()
    {
        #region Associating text file with object in this script if there isn't already one
        //if text is empty, we need to add it
        if (theText == null)
        {
            Interactable intobj;
            intobj = gameObject.GetComponent<Interactable>();
            //text only needed for Interactable items.
            if (intobj != null)
            {
                //getting text for object (item or obstacle)
               if (intobj.item != null)
                {
                    theText = intobj.item.createText();
                }
                else
                {
                   theText = intobj.obstacle.createText();
                }
            }
        }
        #endregion
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        theTextBox = FindObjectOfType<TextboxManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitForPress && Input.GetKeyDown(KeyCode.F))
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextbox();

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

            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextbox();

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
}
