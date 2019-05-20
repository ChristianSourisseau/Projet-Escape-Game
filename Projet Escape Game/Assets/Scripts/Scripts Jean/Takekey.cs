using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takekey : MonoBehaviour
{
    public GameObject key;
	private bool present;
	public bool goldkey;
	
    void Start()
    {
        key.SetActive(true);
		present = false;
		goldkey = false;
    }
	
	
	void OnTriggerEnter2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = true;
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		present = false;			
		}
	}
	
	void Update()
	{
	
		if (Input.GetKeyDown(KeyCode.E) && present)
		{
		key.SetActive(false);
		goldkey = true;
		}
	}
	
	
}
