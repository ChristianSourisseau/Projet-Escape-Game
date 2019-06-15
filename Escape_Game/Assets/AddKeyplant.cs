using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKeyplant : MonoBehaviour
{
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.keyplant.Add(this.gameObject);
}
}
