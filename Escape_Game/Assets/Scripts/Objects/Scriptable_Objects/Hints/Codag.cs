using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Codag", menuName = "Objects/Hints/Codag")]
public class Codag : Hint
{

    public override void initialise()
    {
        name = "Un Codag";
        description = "Un jeu de logique peu commun.\nCertains emplacements contiennent des traces de peinture...";
    }

    public override bool verifCode(int R, int V, int B, int J)
    {
        return (R == Prem && V == Deux && B == Trois && J == Quatr);
    }


}
