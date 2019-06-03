using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Lock", menuName = "Objects/Obstacles/Lock")]
public class Lock : Obstacle
{
    public Key key;

    public bool isRightKey(Key key)
    {
        return key.Equals(this);
    }
}
