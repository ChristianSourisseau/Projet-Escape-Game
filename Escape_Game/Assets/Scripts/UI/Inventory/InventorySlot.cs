using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button interactButton;

    Item item;

    public void Start()
    {
        interactButton.onClick.AddListener(onUsedItem);
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
       // interactButton.interactable = false;
    }

    public void onUsedItem()
    {
        Debug.Log("Button has been pressed");
        Inventory.instance.itemUsed(item);
    }

}
