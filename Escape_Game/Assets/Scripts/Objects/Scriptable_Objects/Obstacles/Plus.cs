using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Plus", menuName = "Objects/Obstacles/Plus")]
public class Plus : Obstacle
{
	[SerializeField]
	private Tableau tableau = null;
  

   public override void DoSomething() {
   		tableau.incrementValue();
      if (tableau.onValueChangedCallback != null)
      	tableau.onValueChangedCallback.Invoke();
   }
}


