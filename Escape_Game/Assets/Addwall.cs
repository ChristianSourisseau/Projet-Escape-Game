using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addwall : MonoBehaviour
{
    
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.walllist.Add(this.gameObject);
	}


}
