using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Item item;
    public Obstacle obstacle;

    public void Start()
    {
        
    }

    public void Pickup()
    {
        Debug.Log("Picking up : " + item.name);
        if (Inventory.instance.Add(item))
        {
            Destroy(gameObject);
        }
    }
}
