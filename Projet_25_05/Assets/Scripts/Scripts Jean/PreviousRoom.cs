
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PreviousRoom : MonoBehaviour
{
	public TextMeshProUGUI RoomText; //"Room X"
	public GameObject Canvas;
	
	public GameObject Text; //"Press E to reach next room"
	public int room;

	private bool present;
	
    void Start()
    {
        Text.SetActive(false);
		present = false;
		
		
		Canvas = GameObject.FindGameObjectWithTag("CanvasRoom");
		RoomText = GameObject.FindGameObjectWithTag("RoomCounter").GetComponent<TextMeshProUGUI>();
    }
	
	
	void OnTriggerEnter2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = true;
		Text.SetActive(true);
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = false;
        Text.SetActive(false);
		
		}
	}
	
	void Update()
	{
	
		if (Input.GetKeyDown(KeyCode.E) && present)
		{
			
			if (RoomText.GetComponent<RoomCounter>().count == 1){
				
				Destroy(RoomText);
				Destroy(Canvas.gameObject);

			}
			else{
				RoomText.text = "Room " + (RoomText.GetComponent<RoomCounter>().count -1).ToString();
			}
			
			SceneManager.LoadScene(room);


		}
	}
	
	
}
