using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Inventory : MonoBehaviour
{
    
    #region Singleton
    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one Instance of Inventory found");
            return;
        }

        instance = this;

        tooltip = ToolTip.instance;
    }
    #endregion

    private ToolTip tooltip;


    //when Inventory is changed, call this method to do something
    //example : update UI
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

<<<<<<< HEAD
    [SerializeField]
    private GameObject tooltip = null; 

=======
>>>>>>> 389bda4032fc9a510e21a741249aad26f879c27e
    public List<Item> items = new List<Item>();
    public int space = 7;

    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Not enough room");
            return false;
        }
        items.Add(item);
        //Update UI to add item icon to inventory
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        return true;
    }
    public void itemUsed(Item item)
    {
        Interactable intObj = gameObject.GetComponent<PlayerInteract>().getInteractObj();
        if (intObj != null)
        {
            intObj.useItemOnObject(item);
        }        
    }

    public void remove(Item item)
    {
        items.Remove(item);
        //Update UI to remove item icon from inventory
        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public void ShowTooltip(Vector3 position, IDescribable description)
<<<<<<< HEAD
    {	
		if(tooltip != null){
			tooltip.SetActive(true);
			tooltip.transform.position = position;
			tooltip.GetComponentInChildren<Text>().text = description.GetDescription();
		}
        
=======
    {
        tooltip.ShowTooltip(position, description);
>>>>>>> 389bda4032fc9a510e21a741249aad26f879c27e
    }

    public void HideTooltip()
    {
<<<<<<< HEAD
		if(tooltip != null){
			tooltip.SetActive(false);
		}
=======
        tooltip.HideTooltip();
>>>>>>> 389bda4032fc9a510e21a741249aad26f879c27e
    }

}

    
