using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Drawing", menuName = "Objects/Hints/Drawing")]
public class Drawing : Hint
{
    public Drawing(int Prem, int Deux, int Trois, int Quatr)
    {
        //identifiant = "Dessin";
        description = "Un coloriage simple, sans doute de la main d'un enfant : c'est une maison, ";
        if (Prem > 0) description += "un arbre à " + Prem + " pommes,";
        if (Deux > 0) description += Deux + " bosquets,";
        if (Trois > 0) description += Trois + " poissons dans une mare,";
        if (Quatr > 0) description += Quatr + " étoiles dans le ciel,";
        description += "et rien d'autre de très important.";
    }
}
