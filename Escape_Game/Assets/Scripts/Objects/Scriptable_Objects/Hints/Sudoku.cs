using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Sudoku", menuName = "Objects/Hints/Sudoku")]
public class Sudoku : Hint
{
   public Sudoku(int Prem, int Deux, int Trois, int Quatr) {
		//identifiant = "S" + Prem + Deux + Trois + Quatr;
		description = "Un simple sudoku. Quelqu'un a colorié dans l'emplacement de chiffres manquant.";
	}
}
