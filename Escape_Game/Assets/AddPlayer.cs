using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{
	private EnigmaTemplates templates;

    void Start(){
		
		templates = GameObject.FindGameObjectWithTag("Enigma").GetComponent<EnigmaTemplates>();
		templates.player.Add(this.gameObject);
	}
}
