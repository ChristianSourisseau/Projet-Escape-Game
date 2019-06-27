using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserdigioff : MonoBehaviour
{
	private bool open;
	
	
	private GameObject dellaser;
	
	private GameObject EnigmaTemplates;
	
    void Start()
    {
        EnigmaTemplates = GameObject.FindGameObjectWithTag("Enigma");
		open = false;
    }

    // Update is called once per frame
    void Update()
    {
        open = EnigmaTemplates.GetComponent<EnigmaTemplates>().cadena.GetComponent<Cadena>().isopen;
		if (open){
			EnigmaTemplates.GetComponent<EnigmaTemplates>().laserdigicodetemp.SetActive(false);
		}
		
    }
}
