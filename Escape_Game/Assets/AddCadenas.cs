using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCadenas : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listcadenas.Add(this.gameObject);
	}
}
