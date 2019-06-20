using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
	private bool open;
	private int scena;
	
	private GameObject EnigmaTemplates;


	
	//scena 1

	private int whitenumber;
	private int rednumber;
	
	

	

	void Start(){
		
		EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");

		scena = EnigmaTemplates.GetComponent<EnigmaTemplates>().scena;

		open = false;
		
		
	}
	
	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" && scena == 1)
		{
			whitenumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumber;
			rednumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().rednumber;

			
			if (whitenumber == rednumber)
			{
				open = true;
			}
		}
		
		if (player.gameObject.tag == "Player" && scena == 2)
		{
			open = GameObject.FindGameObjectWithTag("Press").GetComponent<OnPressure>().press;			
		}
	}
	
	void OnTriggerExit2D (Collider2D player){
		if (player.gameObject.tag == "Player"){
			open = false;
		}
	}

	
	void Update()
	{
	
		if (Input.GetKeyDown(KeyCode.E) && open)
		{
			SceneManager.LoadScene("Scenes/Salles");
		}
	}
	
	

	

	
}
