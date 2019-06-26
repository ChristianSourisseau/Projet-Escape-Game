using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBox : MonoBehaviour
{
  
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listboxes.Add(this.gameObject);
	}


}
