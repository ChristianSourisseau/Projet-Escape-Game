﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowText : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
	// Update is called once per frame
	
	
	
		void OnTriggerEnter2D (Collider2D player)
		{
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }
	
   
	}
}
