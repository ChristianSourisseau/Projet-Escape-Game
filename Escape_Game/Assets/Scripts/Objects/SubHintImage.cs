using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubHintImage : HintImage
{
    HintImage hi;

    void Start()
    {
        hi = HintImage.instance;
        hi.onHintChangedCallback += init;
    }


    private void init()
    {
        Hint h = gameObject.GetComponent<Interactable>().hint;

        if (h != null)
        {
            h.initialise();
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


}
