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
	public int difficulty;


	public float waitTime = 4f;
	
	private int rand;

	void Start(){
		difficulty = 1;
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("RoomParts").GetComponent<RoomTemplates>();
		Invoke("Spawn", 0.1f);
	}


	void Spawn(){
		if(spawned == false){
			
			if(difficulty == 1){
			
				if(openingDirection == 1){
					rand = Random.Range(0, templates.bl.Length);
					Instantiate(templates.bl[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 2){
					rand = Random.Range(0, templates.bm.Length);
					Instantiate(templates.bm[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 3){
					rand = Random.Range(0, templates.br.Length);
					Instantiate(templates.br[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 4){
					rand = Random.Range(0, templates.mr.Length);
					Instantiate(templates.mr[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 5){
					rand = Random.Range(0, templates.mm.Length);
					Instantiate(templates.mm[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 6){
					rand = Random.Range(0, templates.tl.Length);
					Instantiate(templates.tl[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 7){
					rand = Random.Range(0, templates.tm.Length);
					Instantiate(templates.tm[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 8){
					rand = Random.Range(0, templates.tr.Length);
					Instantiate(templates.tr[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 9){
					rand = Random.Range(0, templates.ml.Length);
					Instantiate(templates.ml[rand], transform.position, Quaternion.identity);
				}
				
				spawned = true;
			}
			
			if(difficulty == 2){
			
				if(openingDirection == 6){
					rand = Random.Range(0, templates.tl.Length);
					Instantiate(templates.tl[rand], transform.position, Quaternion.identity);
				}else if(openingDirection == 3){
					rand = Random.Range(0, templates.br.Length);
					Instantiate(templates.br[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 4){
					rand = Random.Range(0, templates.mr.Length);
					Instantiate(templates.mr[rand], transform.position, Quaternion.identity);
				}
				
				spawned = true;
			
			}
		}
	}

	
}
