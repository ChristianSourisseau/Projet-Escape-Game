using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawner : MonoBehaviour
{
	private ChamberTemplates templates;
	private int rand;
	public bool chamberspawned = false;
	
	public float waitTime = 4f;

	
	void Start(){
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("Chambers").GetComponent<ChamberTemplates>();
		Invoke("Spawn", 2f);
	}


	


	void Spawn(){
		
		if(chamberspawned == false){
			
			rand = Random.Range(0, templates.doors.Length);
			Instantiate(templates.doors[rand], transform.position, Quaternion.identity);


		}
		chamberspawned = true;

	}
  }
