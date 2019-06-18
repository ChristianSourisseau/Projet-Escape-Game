using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New combinationLock", menuName = "Objects/Obstacles/Cadena")]
public class CombinationLock : Obstacle
{
    [SerializeField]
    private GameObject cadena;

    public override void DoSomething()
    {
        Cadena c = cadena.GetComponent<Cadena>();
        if (c != null)
        {
            c.Open();
        }
        else
        {
            Debug.Log("Cannot find instance of Cadena");
        }
    }
}
