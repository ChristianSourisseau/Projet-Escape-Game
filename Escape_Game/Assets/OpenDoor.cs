using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
	private bool present;
	private GameObject EnigmaTemplates;

	private int whitenumber;
	private int rednumber;
	
	private int scena;

	void Start(){
		EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");
		scena = EnigmaTemplates.GetComponent<EnigmaTemplates>().scena;
	}
	
	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" && scena == 1)
		{
			whitenumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumber;
			rednumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().rednumber;

			
			if (whitenumber == rednumber )
			{
				SceneManager.LoadScene(2);


			}
		}
	}
	
	

	

	
}
