using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHintSudo : MonoBehaviour
{
     private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listhintsudo.Add(this.gameObject);
	}
}
