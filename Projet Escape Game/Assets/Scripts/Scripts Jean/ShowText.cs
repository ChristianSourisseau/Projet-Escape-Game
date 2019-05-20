using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowText : MonoBehaviour
{
	public GameObject key;
    public GameObject TextChest;
	public GameObject TextChestwithkey;
	private bool present;


	//At the start the player is not in the collide's chest zone then present is false.
	//And he must not see any of the messages.
    void Start()
    {
        TextChest.SetActive(false);
		TextChestwithkey.SetActive(false);
		present = false;
    }

	
	//Set present to true if the player enter in the collide zone.
	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" )
		{
			present = true;
		}
	}
	
	//Set present to false if the player leave the collide zone. And hide all text.
	void OnTriggerExit2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player") 
		{
			TextChest.SetActive(false);
			TextChestwithkey.SetActive(false);
			present = false;

		}
	}
	

	
	//if the player is in the collide zone and he own the goldkey then he will see the goldkeytext. 
	//Else if he is just in the collide zone without the key he will see the normal text "locked chest".
	void Update()
	{
		if (key.GetComponent<Takekey>().goldkey && present)
		{
			TextChestwithkey.SetActive(true);
		}
		else if(present){
			TextChest.SetActive(true);
		}

	}
   
	
}
