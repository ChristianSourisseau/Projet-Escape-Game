using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFloorDeco : MonoBehaviour
{
   
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listfloor.Add(this.gameObject);
	}


}
