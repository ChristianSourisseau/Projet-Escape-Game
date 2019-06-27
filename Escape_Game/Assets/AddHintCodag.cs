using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHintCodag : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listhintcodag.Add(this.gameObject);
	}
}
