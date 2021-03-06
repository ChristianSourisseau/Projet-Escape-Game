﻿using UnityEngine;

public enum TypeOfItem { Key, Tool, Hint }

public class Item : Objet, IDescribable
{

    [SerializeField]
    private TypeOfItem type;

    //new public string name = "Item"; //overriding the old definition for name
    public virtual bool correctInteraction(Obstacle l)
    {
        return false;
    }

    public virtual string GetDescription()
    {
        string color = string.Empty;

        switch (type)
        {
            case TypeOfItem.Key:
                color = "#00ff00ff";
                break;
            case TypeOfItem.Tool:
                color = "#F0A00C";
                break;
           /* case TypeOfItem.Hint:
                color = "#00ACFF";
                break;
                */
        }

        return string.Format("<color={0}>{1}</color>", color, name) +"\n"+ description;
    }
}
