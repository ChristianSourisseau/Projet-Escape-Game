using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLaser : MonoBehaviour
{
  
  
    private EnigmaTemplates templates;
	
	void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.listposlaser.Add(this.gameObject);
	}




}
