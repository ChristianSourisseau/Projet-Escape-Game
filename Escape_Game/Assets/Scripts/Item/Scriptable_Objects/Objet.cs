
using UnityEngine;

public class Objet : ScriptableObject
{
    public string description = "an object";
    new public string name = "Object"; //overriding the old definition for name
    public Sprite icon = null;
}
