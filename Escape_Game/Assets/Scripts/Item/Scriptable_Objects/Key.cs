using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Key", menuName = "Objects/Items/Key")]
public class Key : Item
{
    public Lock keyhole;

    public bool isRightLock(Lock keyhole)
    {
        return keyhole.Equals(this);
    }
}
