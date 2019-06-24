using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxManager : MonoBehaviour
{
  
    public GameObject textBox;
    public Text theText;


    public string onStartText = null;
    public string[] textLines;
    public int currentLine;
    public int endAtLine;
    public bool isActive;

    public static Move player;

    public static TextboxManager instance;


    // Start is called before the first frame update

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one Instance of TextBoxManager found");
            return;
        }

        instance = this;


    ActivateTextAtLine[] tab = FindObjectsOfType<ActivateTextAtLine>();
        Interactable I = null;
        foreach (ActivateTextAtLine a in tab)
        {
            I = a.gameObject.GetComponent<Interactable>();
            if (I.hint != null)
            {
                a.theText = I.hint.description;
            }
            else if(I.obstacle != null) {
                a.theText = I.obstacle.description;

            }
            else if (I.item != null) {
                a.theText = I.item.name + "\n" + I.item.description;
            }
        }
    }

    void Start()
    {
        player = FindObjectOfType<Move>();

        if (onStartText != null)
        {
            textLines = (onStartText.Split('\n'));
            endAtLine = textLines.Length;
            EnableTextbox();
        }
        DisableTextBox();
    }


    void Update()
    {
        if (isActive)
        {
            theText.text = textLines[currentLine];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (currentLine == endAtLine)
                {
                    DisableTextBox();
                    return;
                }
                    currentLine++;
            }
        }
    }


    public void EnableTextbox()
    {
        isActive = true;
        textBox.SetActive(true);
        if (player.isAllowedToMove)
        {
            player.isAllowedToMove = false;
        }
        
    }

    public void DisableTextBox()
    {
        isActive = false;
        textBox.SetActive(false);
        currentLine = 0;
        player.isAllowedToMove = true;
    }

    public void ReloadScript(string text)
    {
        textLines = (text.Split('\n'));
        endAtLine = textLines.Length -1;
    }
}
