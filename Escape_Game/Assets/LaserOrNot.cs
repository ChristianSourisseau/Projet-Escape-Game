using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOrNot : MonoBehaviour
{
    private int scena;
	private int whitenumber;
	private int rednumber;
	private bool open;
	
	
	private GameObject dellaser;
	
	private GameObject EnigmaTemplates;

	
	void Start()
	{
		EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");
		open = false;
	}
		
	
	
    void Update()
    {
		
		scena = EnigmaTemplates.GetComponent<EnigmaTemplates>().scena;
		dellaser = EnigmaTemplates.GetComponent<EnigmaTemplates>().dellaser;

		
        if ( scena == 1)
		{
			whitenumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().whitenumber;
			rednumber = EnigmaTemplates.GetComponent<EnigmaTemplates>().rednumber;

			
			if (whitenumber == rednumber)
			{
				open = true;
			}
		}
		
		if ( scena == 2)
		{
			open = GameObject.FindGameObjectWithTag("Press").GetComponent<OnPressure>().press;			
		}
		
		
		if (open){
			dellaser.SetActive(false);
		}
		else{
			if(dellaser != null){
			dellaser.SetActive(true);
			}

		}
    }
}
