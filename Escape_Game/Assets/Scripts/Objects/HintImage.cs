using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class HintImage : MonoBehaviour
{
    [SerializeField]
    private Image im;
    [SerializeField]
    private GameObject exit;
    [SerializeField]
    private Riddle r;

    private Move playercontrol;
    private Sprite s;
    public delegate void OnHintChanged();
    public OnHintChanged onHintChangedCallback;

    public static HintImage instance;

    void Awake()
    {
        instance = this;
    }

    protected virtual void Start()
    {
        initRiddle();

        Hint h = gameObject.GetComponent<Interactable>().hint;
        
        
        h.initialise();
        //update sprite
        im.sprite = h.GetSprite();

        playercontrol = GameObject.FindGameObjectWithTag("Player").GetComponent<Move>();

        im.enabled = false;
        exit.SetActive(false);
    }


   

    public void ShowHint()
    {
        im.enabled = true;
        exit.SetActive(true);
        if (playercontrol != null)
        {
            playercontrol.isAllowedToMove = false;
        }
        else
        {
            Debug.LogError("Player movement script not found");
        }
    }

    public void HideHint()
    {
        im.enabled = false;
        exit.SetActive(false);

        if (playercontrol != null)
        {
            playercontrol.isAllowedToMove = true;
        }
        else
        {
            Debug.LogError("Player movement script not found");
        }
    }


    private void initRiddle()
    {
        if (r != null)
        {
            Interactable[] fillhint = gameObject.GetComponentsInChildren<Interactable>();
            Hint[] hintelements = r.getHintElements();
            fillhint[1].hint = hintelements[0];
            fillhint[2].hint = hintelements[1];
            if (onHintChangedCallback != null)
                onHintChangedCallback.Invoke();
        }
    }
}
