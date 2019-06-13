using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
	// 1 --> need bl
	// 2 --> need bm
	// 3 --> need br
	// 4-->  need mr
	// 5 --> need mm
	// 6 --> need tl
	// 7 --> need tm
	// 8 --> need tr
	// 9 --> need ml



	private RoomTemplates templates;
	public bool spawned = false;

	public float waitTime = 4f;

	void Start(){
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("RoomParts").GetComponent<RoomTemplates>();
		Invoke("Spawn", 0.1f);
	}


	void Spawn(){
		if(spawned == false){
			if(openingDirection == 1){
				Instantiate(templates.bl[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 2){
				Instantiate(templates.bm[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 3){
				Instantiate(templates.br[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 4){
				Instantiate(templates.mr[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 5){
				Instantiate(templates.mm[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 6){
				Instantiate(templates.tl[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 7){
				Instantiate(templates.tm[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 8){
				Instantiate(templates.tr[0], transform.position, Quaternion.identity);
			} else if(openingDirection == 9){
				Instantiate(templates.ml[0], transform.position, Quaternion.identity);
			} 			
			spawned = true;
		}
	}

	
}
