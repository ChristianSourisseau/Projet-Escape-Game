using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Drawing", menuName = "Objects/Hints/Drawing")]
public class Drawing : Hint
{
    public Drawing()
    {
        System.Random rand = new System.Random();
        Prem = rand.Next(10); Deux = rand.Next(10); Trois = rand.Next(10); Quatr = rand.Next(10);
        name = "Dessin";
        description = "Un coloriage simple, sans doute de la main d'un enfant : c'est une maison, ";
        if (Prem > 0) description += "un arbre à " + Prem + " pommes,";
        if (Deux > 0) description += Deux + " bosquets,";
        if (Trois > 0) description += Trois + " poissons dans une mare,";
        if (Quatr > 0) description += Quatr + " étoiles dans le ciel,";
        description += "et rien d'autre de très important.";
    }

    public override bool verifCode(int one, int two, int three, int four, int m)
    {
        return (one == Prem && two == Deux && three == Trois && four == Quatr);
    }
}
