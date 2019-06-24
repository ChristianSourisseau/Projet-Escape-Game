using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class HintImage : MonoBehaviour
{
    [SerializeField]
    protected Image im;
    [SerializeField]
    protected GameObject exit;
    [SerializeField]
    private Riddle r;

    [SerializeField]
    private GameObject SubA;

    [SerializeField]
    private GameObject SubB;


    protected Move playercontrol;
    private Sprite s = null;


    public delegate void OnHintChanged();
    public OnHintChanged onHintChangedCallback;

    public static HintImage instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Hint h = gameObject.GetComponent<Interactable>().hint;

        if (h != null)
        {
            h.initialise();
        }
        else
        {
            Debug.Log("getcomponent not working in HintImage");
        }
        if (r != null)
        {
            initRiddle();
        }
        //update sprite
        im.sprite = h.GetSprite();

        playercontrol = GameObject.FindObjectOfType<Move>();
        if (playercontrol == null)
        {
            Debug.LogWarning("Can't find instance of move script");
        }

        HideHint();
    }




    public void ShowHint()
    {
        im.gameObject.SetActive(true);
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
        im.gameObject.SetActive(false);
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

        Interactable IntA = SubA.GetComponent<Interactable>();
        Interactable IntB = SubB.GetComponent<Interactable>();

        IntA.hint = r.getSubA();
        IntB.hint = r.getSubB();

        if (onHintChangedCallback != null)
            onHintChangedCallback.Invoke();
        else
            Debug.Log("we got a problem with delegate onHintChangedCallBack not assigned");
    }
}
