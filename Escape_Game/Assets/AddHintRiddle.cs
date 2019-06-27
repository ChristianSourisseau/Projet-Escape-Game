using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHintRiddle : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listhintriddle.Add(this.gameObject);
	}
}
