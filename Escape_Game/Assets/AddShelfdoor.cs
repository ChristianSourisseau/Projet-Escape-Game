using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddShelfdoor : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.shelfdoor.Add(this.gameObject);
}
}
