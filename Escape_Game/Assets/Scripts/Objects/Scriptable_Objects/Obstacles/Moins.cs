using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Moins", menuName = "Objects/Obstacles/Moins")]
public class Moins : Obstacle
{
	[SerializeField]
	private Tableau tableau = null;

   public override void DoSomething() {
   		tableau.decrementValue();
      if (tableau.onValueChangedCallback != null)
      	tableau.onValueChangedCallback.Invoke();
   }
}

