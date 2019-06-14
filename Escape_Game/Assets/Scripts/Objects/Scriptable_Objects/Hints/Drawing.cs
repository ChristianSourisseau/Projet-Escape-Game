using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Drawing", menuName = "Objects/Hints/Drawing")]
public class Drawing : Hint
{

    public override void initialise()
    {
        System.Random rand = new System.Random();
        Prem = rand.Next(10); Deux = rand.Next(10); Trois = rand.Next(10); Quatr = rand.Next(10);
        name = "Dessin";
        description = "Un coloriage simple, sans doute de la main d'un enfant : c'est une maison, ";
        description += "un arbre à " + Prem + " pommes,";
        description += Deux + " bosquets,";
        description += Trois + " poissons dans une mare,";
        description += Quatr + " étoiles dans le ciel,";
        description += "et rien d'autre de très important.";
    }
}
