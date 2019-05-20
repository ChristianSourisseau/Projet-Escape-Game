using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextKey : MonoBehaviour
{
    public GameObject TextKey;

    void Start()
    {
        TextKey.SetActive(false);
    }

	
	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" )
		{
			TextKey.SetActive(true);
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player")
		{
			TextKey.SetActive(false);
		}
	}
	
}
