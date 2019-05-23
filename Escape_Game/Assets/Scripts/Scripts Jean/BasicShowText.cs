﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShowText : MonoBehaviour
{
    public GameObject Text;

    void Start()
    {
        Text.SetActive(false);
    }

	
	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player" )
		{
			Text.SetActive(true);
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
		if (player.gameObject.tag == "Player")
		{
			Text.SetActive(false);
		}
	}
	
}