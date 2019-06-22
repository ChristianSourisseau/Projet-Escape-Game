using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class OpenDoor : MonoBehaviour
{
	private bool open;
	private int scena;
	
	private GameObject EnigmaTemplates;
	
	
	
	
	
	public TextMeshProUGUI RoomText; //"Room X"
	public GameObject RoomCounter;



	
	//scena 1

	private int whitenumber;
	private int rednumber;
	
	

	

	void Start(){
		
		EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");

		scena = EnigmaTemplates.GetComponent<EnigmaTemplates>().scena;

		open = false;
		
		
		RoomCounter = GameObject.FindGameObjectWithTag("RoomCounter");
		RoomText = RoomCounter.GetComponent<TextMeshProUGUI>();
		RoomText.text = "Room " + (RoomText.GetComponent<RoomCounter>().count ).ToString();
		
		

		
		
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
			RoomText.GetComponent<RoomCounter>().count = RoomText.GetComponent<RoomCounter>().count + 1;
			RoomText.text = "Room " + (RoomText.GetComponent<RoomCounter>().count ).ToString();
			
			if(RoomText.GetComponent<RoomCounter>().count > 3){
				RoomText.GetComponent<RoomCounter>().difficulty = 2;
			}
			
			
			SceneManager.LoadScene("Scenes/Salles");
			
		}
	}
	
	

	

	
}
