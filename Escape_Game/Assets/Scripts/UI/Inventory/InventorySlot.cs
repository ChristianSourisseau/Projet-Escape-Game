using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image icon;
    public Button interactButton;

    Item item;

    public void Start()
    {
        interactButton.interactable = false;
    }

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        interactButton.interactable = true;
    }

    public void ClearSlot ()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        interactButton.interactable = false;
    }

    public void onUsedItem()
    {
        Debug.Log("Button has been pressed");
        Inventory.instance.itemUsed(item);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(item != null)
        {
            Inventory.instance.ShowTooltip(transform.position,item);
            Debug.Log("Show Tooltip");
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Inventory.instance.HideTooltip();
        Debug.Log("Exit");
    }
}
