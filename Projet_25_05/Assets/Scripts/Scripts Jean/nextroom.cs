using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class nextroom : MonoBehaviour
{
	public TextMeshProUGUI RoomText; //"Room X"
	
	public GameObject Text; //"Press E to reach next room"
	public int room;

	private bool present;
	
    void Start()
    {
        Text.SetActive(false);
		present = false;
		
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
			SceneManager.LoadScene(room);
			RoomText.GetComponent<RoomCounter>().count = RoomText.GetComponent<RoomCounter>().count + 1;
			RoomText.text = "Room " + (RoomText.GetComponent<RoomCounter>().count ).ToString();

		}
	}
	
	
}
