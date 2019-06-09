using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Key", menuName = "Objects/Items/Key")]
public class Key : Item
{
    public Lock door;

    public override bool correctInteraction(Obstacle l)
    {
        Debug.Log("CorrectInterraction of KEY was called");
        return l.GetInstanceID() == door.GetInstanceID();
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "\nCette clé ouvre probablement la porte de la cellule";
    }
}
