﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCounter : MonoBehaviour
{
	
	public int count;
	public int difficulty;

	
	
    void Awake()
    {
		count = 4;
        
    }
	void Start(){
		
		difficulty = 1;
		
		
	}

    
}
