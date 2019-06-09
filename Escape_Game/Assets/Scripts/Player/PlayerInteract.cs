using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    
    private GameObject curIntObj = null;
    private Interactable curIntObjScript = null;

    public Interactable getInteractObj()
    {
        return curIntObjScript;
    }

    // THE PLAYER CAN INTERACT ONLY IF IT HAS THE TAG "Interactable"
    private void Update()
    {
        if (Input.GetButtonDown("Interact") && curIntObj ){
                if (curIntObjScript != null)
                 {
                    // Makes sure we only pickup an item and not an obstacle.
                    if (curIntObjScript.item != null)
                    {
                         curIntObjScript.Pickup();
                    }
            }
        }
    }
    //If collision with Interactable object sets current Interactable Object 
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log(collision.name);
            curIntObj = collision.gameObject;
            curIntObjScript = curIntObj.GetComponent<Interactable>();
    }

    //exiting collision zone sets current Interractable Object to null
    private void OnTriggerExit2D(Collider2D collision)
    {
            if (collision.gameObject == curIntObj)
            {
                curIntObj = null;
                curIntObjScript = null;
            }
    }
}
