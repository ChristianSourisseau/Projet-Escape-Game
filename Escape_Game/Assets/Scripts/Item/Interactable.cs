using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Item item;

    public void Pickup()
    {
        Debug.Log("Picking up : " + item.name);
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }
}
