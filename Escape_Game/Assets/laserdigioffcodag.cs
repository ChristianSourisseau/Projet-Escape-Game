using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserdigioffcodag : MonoBehaviour
{
    
	private bool open;
	
		private GameObject EnigmaTemplates;
	
    void Start()
    {
        EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");
		open = false;
    }

    // Update is called once per frame
    void Update()
    {
        open = EnigmaTemplates.GetComponent<EnigmaTemplates>().cadena2.GetComponent<Cadena>().isopen;
		
		if (open){
			EnigmaTemplates.GetComponent<EnigmaTemplates>().laserdigicodetemp2.SetActive(false);
		}
		
    }


}
