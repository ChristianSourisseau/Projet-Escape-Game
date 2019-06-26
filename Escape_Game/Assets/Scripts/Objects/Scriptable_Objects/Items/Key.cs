using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Key", menuName = "Objects/Items/Key")]
public class Key : Item
{
    public Lock door;

    public override bool correctInteraction(Obstacle l)
    {
        return l.GetInstanceID() == door.GetInstanceID();
    }

}
