using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : Objet
{
    public int Prem = 0;
    public int Deux = 0;
    public int Trois = 0;
    public int Quatr = 0;
    public int Myst = 0;

    public Image image;

    //Keeping code in case of future use.
    /*
    public void InitializeHint()
    {
        System.Random rand = new System.Random();
        int num = rand.Next(8);
        switch (num)
        {
            case 0: Prem = 3; Deux = 5; Trois = 8; Quatr = 2; Myst = 5; break;
            case 1: Prem = 1; Deux = 3; Trois = 3; Quatr = 7; Myst = 7; break;
            case 2: Prem = 5; Deux = 1; Trois = 6; Quatr = 3; Myst = 1; break;
            case 3: Prem = 2; Deux = 0; Trois = 1; Quatr = 9; Myst = 9; break;
            case 4: Prem = 2; Deux = 4; Trois = 1; Quatr = 1; Myst = 2; break;
            case 5: Prem = 3; Deux = 1; Trois = 0; Quatr = 5; Myst = 0; break;
            case 6: Prem = 9; Deux = 4; Trois = 0; Quatr = 6; Myst = 6; break;
            case 7: Prem = 7; Deux = 5; Trois = 8; Quatr = 4; Myst = 8; break;
        }

        createHint(Prem, Deux, Trois, Quatr, Myst);
    }
    */


    public virtual bool verifCode(int one, int two, int three, int four, int m)
    {
        return false;
    }

}
