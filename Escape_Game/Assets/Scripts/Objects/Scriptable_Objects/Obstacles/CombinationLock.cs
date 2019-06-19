using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New combinationLock", menuName = "Objects/Obstacles/Cadena")]
public class CombinationLock : Obstacle
{
    public override void DoSomething()
    {
        if (obj != null)
        {
            Cadena cadena = obj.gameObject.GetComponent<Cadena>();
            if (cadena != null)
            {
                cadena.Open();
            }
            else
            {
                Debug.Log("CombinationLock.cs : Cannot find Cadena.cs for Lock");
            }
        }
        else
        {
            Debug.Log("CombinationLock.cs : Cannot find GameObject for Lock");
        }
    }
}
