using UnityEngine;

public enum TypeOfItem { Key, Tool, Hint }

public class Item : Objet, IDescribable
{
    [SerializeField]
    private string title;

    [SerializeField]
    private TypeOfItem type;

    //new public string name = "Item"; //overriding the old definition for name
    public virtual bool correctInteraction(Obstacle l)
    {
        Debug.Log("CorrectInteraction of ITEM was called");
        return true;
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
            case TypeOfItem.Hint:
                color = "#00ACFF";
                break;

        }

        return string.Format("<color={0}>{1}</color>", color, title);
    }
}
