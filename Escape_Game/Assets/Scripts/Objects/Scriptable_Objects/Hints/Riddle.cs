using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Riddle", menuName = "Objects/Hints/Riddle")]
public class Riddle : Hint
{
    [SerializeField]
    private EnigmaElementA[] hintsA;
    [SerializeField]
    private EnigmaElementB[] hintsB;


    private EnigmaElementA partA;
    private EnigmaElementB partB;


    public Hint getSubA()
    {
        return partA;
    }

    public Hint getSubB()
    {
        return partB;
    }

    public override void initialise()
    {
        name = "DXXXX";
        description = "Je suis l'astre perdu, la lumière égarée.\n Si vous voulez sortir, il vous faut me trouver.\n Moi";
        System.Random ran = new System.Random();

        partA = hintsA[ran.Next(hintsA.Length)];
        partB = hintsB[ran.Next(hintsB.Length)];
        
        if(partA == null || partB == null)
        {
            Debug.LogError("critical error, no hint elements for riddle");
            return;
        }

        switch (ran.Next(10))
        {
            case 0: description += " qui fait les dizaines, centaines et milliers.";
                Prem = 0; Deux = 0; Trois = 0; Quatr = 0; break;
            case 1: description += " qui ne suis pas bien grand mais qui fait toute armée.";
                Prem = 1; Deux = 1; Trois = 1; Quatr = 2; break;
            case 2: description += ", pair hors-pair et premier des premiers.";
                Prem = 2; Deux = 2; Trois = 2; Quatr = 2; break;
            case 3: description += " qui compte ce qui fut, sera, et ce qui est.";
                Prem = 3; Deux = 3; Trois = 3; Quatr = 3; break;
            case 4: description += " qui, des éléments aux saisons, veux tout carré.";
                Prem = 4; Deux = 4; Trois = 4; Quatr = 4; break;
            case 5: description += " qui vous aide d'une main à compter.";
                Prem = 5; Deux = 5; Trois = 5; Quatr = 5; break;
            case 6: description += ", ce sens occulte que vous ne pouvez utiliser.";
                Prem = 6; Deux = 6; Trois = 6; Quatr = 6; break;
            case 7: description += ", chiffre magique, de vertus et de péchés.";
                Prem = 7; Deux = 7; Trois = 7; Quatr = 7; break;
            case 8: description += ", acrobate, sans égal pour faire le poirier.";
                Prem = 8; Deux = 8; Trois = 8; Quatr = 8; break;
            case 9: description += ", un peu à l'ouest mais plus grande des unités.";
                Prem = 9; Deux = 9; Trois = 9; Quatr = 9; break;
        }
        
        switch (partB.getStarPos())
        {
            case 1: Prem = partA.getStar(); break;
            case 2: Deux = partA.getStar(); break;
            case 3: Trois = partA.getStar(); break;
            case 4: Quatr = partA.getStar(); break;
        }
        switch (partB.getMoonPos())
        {
            case 1: Prem = partA.getMoon(); break;
            case 2: Deux = partA.getMoon(); break;
            case 3: Trois = partA.getMoon(); break;
            case 4: Quatr = partA.getMoon(); break;
        }
        switch (partB.getSunPos())
        {
            case 1: Prem = partA.getSun(); break;
            case 2: Deux = partA.getSun(); break;
            case 3: Trois = partA.getSun(); break;
            case 4: Quatr = partA.getSun(); break;
        }
    }
}
