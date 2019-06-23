using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKeyplant2 : MonoBehaviour
{
    
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.keyplant2.Add(this.gameObject);
	}


}
