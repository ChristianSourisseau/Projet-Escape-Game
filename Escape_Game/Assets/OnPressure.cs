using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPressure : MonoBehaviour
{
	
	public bool press;
	public bool cube;

	public GameObject sprite1;
	public GameObject sprite2;

	
	
    void Start()
    {
		press = false;	
		cube = false;	
		
		sprite1 = GameObject.FindGameObjectWithTag("sprite1");
		sprite2 = GameObject.FindGameObjectWithTag("sprite2");
		sprite2.SetActive(false);


		
    }

	void OnTriggerEnter2D (Collider2D all)
	{
        if (all.gameObject.tag == "Cube") 
        {
			cube = true;
		}
		
		press = true;
		sprite1.SetActive(false);
		sprite2.SetActive(true);


		
	}
	
	void OnTriggerExit2D (Collider2D all)
	{
        if (all.gameObject.tag == "Cube") 
        {
			cube = false;
		}
		press = cube;
		sprite1.SetActive(!press);
		sprite2.SetActive(press);

		
	}
    
}



