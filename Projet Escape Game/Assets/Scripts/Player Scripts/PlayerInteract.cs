using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    
    public GameObject curIntObj = null;
    public Interactable curIntObjScript = null;

    // THE PLAYER CAN INTERACT ONLY IF IT HAS THE TAG "Interactable"
    private void Update()
    {
        if (Input.GetButtonDown("Interact") && curIntObj ){
            //DOES SOMETHING WITH OBJECT
            //FOR NOW JUST PICK UP
                if (curIntObjScript != null)
                {
                Inventory.instance.Add(curIntObjScript.item);
                curIntObj.SendMessage("Pickup"); 
                }
        }
    }
    //If collision with Interactable object sets current Interactable Object 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            Debug.Log(collision.name);
            curIntObj = collision.gameObject;
            curIntObjScript = curIntObj.GetComponent<Interactable>();
        }
    }

    //exiting collision zone sets current Interractable Object to null
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {  
            if (collision.gameObject == curIntObj)
            {
                curIntObj = null;
                curIntObjScript = null;
            }
        }
    }
}
