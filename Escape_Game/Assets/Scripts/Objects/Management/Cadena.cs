using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Cadena : MonoBehaviour
{
    public Image im1;
    public Image im2;
    public Image im3;
    public Image im4;


    [SerializeField]
    Sprite num0;
    [SerializeField]
    Sprite num1;
    [SerializeField]
    Sprite num2;
    [SerializeField]
    Sprite num3;
    [SerializeField]
    Sprite num4;
    [SerializeField]
    Sprite num5;
    [SerializeField]
    Sprite num6;
    [SerializeField]
    Sprite num7;
    [SerializeField]
    Sprite num8;
    [SerializeField]
    Sprite num9;

    [SerializeField]
    private Hint h;

    [SerializeField]
    int Prem = 0;
    [SerializeField]
    int Deux = 0;
    [SerializeField]
    int Trois = 0;
    [SerializeField]
    int Quatr = 0;
    [SerializeField]
    protected Sprite sprite;

    public bool isopen;

    [SerializeField]
    private GameObject canvas;


    void Start()
    {
        Interactable I = gameObject.GetComponent<Interactable>();
        if (I != null)
        {
            I.obstacle.Init(gameObject);
        }
        Close();
        isopen = false;
    }




    public void confirm()
    {
        if (h.verifCode(Prem, Deux, Trois, Quatr))
        {
            isopen = true;
            Close();
        }
        else
        {
            // animation rapide d'erreur
        }
    }

    public void Close()
    {
        canvas.gameObject.SetActive(false);
    }

    public void Open()
    {
        canvas.gameObject.SetActive(true);
    }

    // fct pour cacher le cadena

    // fct pour changer les value des int
    public void top1()
    {
        if (Prem < 9)
        {
            Prem += 1;
        }

    }

    public void top2()
    {
        if (Deux < 9)
        {
            Deux += 1;
        }

    }

    public void top3()
    {
        if (Trois < 9)
        {
            Trois += 1;
        }

    }

    public void top4()
    {
        if (Quatr < 9)
        {
            Quatr += 1;
        }

    }

    public void bot1()
    {
        if (Prem > 0)
        {
            Prem -= 1;
        }
    }

    public void bot2()
    {
        if (Deux > 0)
        {
            Deux -= 1;
        }
    }

    public void bot3()
    {
        if (Trois > 0)
        {
            Trois -= 1;
        }
    }

    public void bot4()
    {
        if (Quatr > 0)
        {
            Quatr -= 1;
        }
    }


    void Update()
    {
        switch (Prem)
        {

            case 0:
                im1.sprite = num0;
                break;

            case 1:
                im1.sprite = num1;
                break;
            case 2:
                im1.sprite = num2;
                break;
            case 3:
                im1.sprite = num3;
                break;

            case 4:
                im1.sprite = num4;
                break;
            case 5:
                im1.sprite = num5;
                break;

            case 6:
                im1.sprite = num6;
                break;

            case 7:
                im1.sprite = num7;
                break;
            case 8:
                im1.sprite = num8;
                break;
            case 9:
                im1.sprite = num9;
                break;
        }


        switch (Deux)
        {

            case 0:
                im2.sprite = num0;
                break;

            case 1:
                im2.sprite = num1;
                break;
            case 2:
                im2.sprite = num2;
                break;
            case 3:
                im2.sprite = num3;
                break;

            case 4:
                im2.sprite = num4;
                break;
            case 5:
                im2.sprite = num5;
                break;

            case 6:
                im2.sprite = num6;
                break;

            case 7:
                im2.sprite = num7;
                break;
            case 8:
                im2.sprite = num8;
                break;
            case 9:
                im2.sprite = num9;
                break;
        }


        switch (Trois)
        {

            case 0:
                im3.sprite = num0;
                break;

            case 1:
                im3.sprite = num1;
                break;
            case 2:
                im3.sprite = num2;
                break;
            case 3:
                im3.sprite = num3;
                break;

            case 4:
                im3.sprite = num4;
                break;
            case 5:
                im3.sprite = num5;
                break;

            case 6:
                im3.sprite = num6;
                break;

            case 7:
                im3.sprite = num7;
                break;
            case 8:
                im3.sprite = num8;
                break;
            case 9:
                im3.sprite = num9;
                break;
        }


        switch (Quatr)
        {

            case 0:
                im4.sprite = num0;
                break;

            case 1:
                im4.sprite = num1;
                break;
            case 2:
                im4.sprite = num2;
                break;
            case 3:
                im4.sprite = num3;
                break;

            case 4:
                im4.sprite = num4;
                break;
            case 5:
                im4.sprite = num5;
                break;

            case 6:
                im4.sprite = num6;
                break;

            case 7:
                im4.sprite = num7;
                break;
            case 8:
                im4.sprite = num8;
                break;
            case 9:
                im4.sprite = num9;
                break;
        }



    }
        // cadena est lié a enigme donc le open si open est true

    }
