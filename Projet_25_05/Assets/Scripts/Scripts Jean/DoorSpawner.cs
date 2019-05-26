using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawner : MonoBehaviour
{
	private ChamberTemplates templates;
	private int rand;
	public bool spawned = false;
	
	public float waitTime = 8f;

	
	void Start(){
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("Chambers").GetComponent<ChamberTemplates>();
		Invoke("Spawn", 4f);
	}


	


	void Spawn(){
		
		if(spawned == false){
			
			rand = Random.Range(0, templates.doors.Length);
			Instantiate(templates.doors[rand], transform.position, Quaternion.identity);


		}
		spawned = true;

	}
  }
