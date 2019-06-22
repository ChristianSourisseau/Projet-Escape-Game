using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseWhiteNumber : MonoBehaviour
{
	
	private GameObject whitenumber;
	private GameObject EnigmaTemplates;
	private GameObject number;

	public GameObject eclat;

	
	private int Enigmawhitenumber;

	
	void Start(){
		EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");
		
		eclat = Instantiate(EnigmaTemplates.GetComponent<EnigmaTemplates>().eclat,transform.position, Quaternion.identity);

		eclat.SetActive(false);

	}

    void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" )
		{
			
			whitenumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().Owhitenumber;
			Enigmawhitenumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumber;
			
			if(Enigmawhitenumber > 0){
			Enigmawhitenumber = Enigmawhitenumber - 1;
			
			EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumber = Enigmawhitenumber;
			

			number = Instantiate(EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumbers[Enigmawhitenumber],whitenumber.transform.position, Quaternion.identity); //Spawn whitenumber
			Destroy(whitenumber);
			EnigmaTemplates.GetComponent<EnigmaTemplates>().Owhitenumber = number;
			
			
			eclat.SetActive(true);

			}
			
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
		{
			if (player.gameObject.tag == "Player" )
			{
				eclat.SetActive(false);

			}
		}
}

