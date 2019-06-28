using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddShelf : MonoBehaviour
{
   private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listshelf.Add(this.gameObject);

	}
}
