using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOffice : MonoBehaviour
{
   private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.bigoffice.Add(this.gameObject);
}
}