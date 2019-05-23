using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextroom : MonoBehaviour
{
	public GameObject Text;

	private bool present;
	
    void Start()
    {
        Text.SetActive(false);
		present = false;
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
			SceneManager.LoadScene(1);

		}
	}
	
	
}
