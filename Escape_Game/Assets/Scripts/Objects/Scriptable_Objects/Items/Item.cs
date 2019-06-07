using UnityEngine;

 public class Item : Objet
{

    //new public string name = "Item"; //overriding the old definition for name
    public virtual bool correctInteraction(Obstacle l)
    {
        return false;
    }
}
