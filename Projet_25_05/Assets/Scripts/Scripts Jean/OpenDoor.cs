using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject CloseDoor;
	public GameObject Door;
	public GameObject TextDoor;

	private bool present;
	
    void Start()
    {
        TextDoor.SetActive(false);
		Door.SetActive(false);

        CloseDoor.SetActive(true);
		present = false;
    }
	
	
	void OnTriggerEnter2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = true;
		TextDoor.SetActive(true);
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = false;
        TextDoor.SetActive(false);
		
		}
	}
	
	void Update()
	{
	
		if (Input.GetKeyDown(KeyCode.E) && present)
		{
		CloseDoor.SetActive(false);
		Door.SetActive(true);

		}
	}
	
	
}
