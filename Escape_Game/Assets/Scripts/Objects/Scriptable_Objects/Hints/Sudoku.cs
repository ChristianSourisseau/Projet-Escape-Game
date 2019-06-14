using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new Sudoku", menuName = "Objects/Hints/Sudoku")]
public class Sudoku : Hint

{
    public override bool verifCode(int one, int two, int three, int four)
    {
        return (one == Prem && two == Deux && three == Trois && four == Quatr);
    }
}

