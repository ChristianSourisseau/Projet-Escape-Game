using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class HintImage : MonoBehaviour
{
    public Image im;
    public GameObject exit;

    void Start()
    {
        im.enabled = false;
        exit.SetActive(false);
        Hint h = gameObject.GetComponent<Interactable>().hint;
        if (h is Sudoku)
        {
            char[] c = im.sprite.name.ToCharArray();
            h.Prem = Convert.ToInt32(c[1].ToString());
            h.Deux = Convert.ToInt32(c[2].ToString());
            h.Trois = Convert.ToInt32(c[3].ToString());
            h.Quatr = Convert.ToInt32(c[4].ToString());
        }
        
    }

    public void ShowHint()
    {
        im.enabled = true;
        exit.SetActive(true);
    }

    public void HideHint()
    {
        im.enabled = false;
        exit.SetActive(false);
    }
}
