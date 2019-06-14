using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : Objet
{
    [SerializeField]
    protected int Prem = 0;
    [SerializeField]
    protected int Deux = 0;
    [SerializeField]
    protected int Trois = 0;
    [SerializeField]
    protected int Quatr = 0;
    [SerializeField]
    protected Sprite sprite;

    public virtual bool verifCode(int one, int two, int three, int four)
    {
        return (one == Prem && two == Deux && three == Trois && four == Quatr);
    }

    //If there's data to initialise, do something...
    public virtual void initialise() { }


    public Sprite GetSprite()
    {
        return this.sprite;
    }
}
