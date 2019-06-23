using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddShelfdoor2 : MonoBehaviour
{
    
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.shelfdoor2.Add(this.gameObject);

	}

}
