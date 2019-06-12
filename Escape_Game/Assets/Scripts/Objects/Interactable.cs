using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public Item item;
    public Obstacle obstacle;
    public Hint hint;


    public void Pickup()
    {
        Debug.Log("Picking up : " + item.name);
        if (Inventory.instance.Add(item))
        {
            Destroy(gameObject);
        }
    }

    public void useItemOnObject(Item item)
    {
       if (item.correctInteraction(obstacle))
        {
            Inventory.instance.remove(item);
        }
       SceneManager.LoadScene("scenarioFin001");
    }

    public void ShowHint()
    {
        gameObject.GetComponent<HintImage>().ShowHint();
    }
}
