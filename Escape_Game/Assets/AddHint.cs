using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHint : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listhint.Add(this.gameObject);
	}
}
