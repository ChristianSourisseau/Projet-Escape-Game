using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoSpawner : MonoBehaviour
{
	private DecoTemplates templates;
	private int rand1;
	private int rand2;

	public bool decospawned = false;
	
	public float waitTime = 4f;

	
	void Start(){
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("Decos").GetComponent<DecoTemplates>();
		Invoke("Spawn", 2f);
	}


	


	void Spawn(){
		
		if(decospawned == false){
			
			rand1 = Random.Range(0,2);
			
			if(rand1 == 0){
			rand2 = Random.Range(0, templates.boxes.Length);
			Instantiate(templates.boxes[rand2], transform.position, Quaternion.identity);
			}


		}
		decospawned = true;

	}
}
