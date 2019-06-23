using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
	
	//difficulty = 1
	// 1 --> need bl
	// 2 --> need bm
	// 3 --> need br
	// 4-->  need mr
	// 5 --> need mm
	// 6 --> need tl
	// 7 --> need tm
	// 8 --> need tr
	// 9 --> need ml
	
	//difficulty = 2
	// 22 --> need b
	// 24-->  need l
	// 25 --> need inter
	// 26 --> need ltr
	// 27 --> need r




	private RoomTemplates templates;
	public bool spawned = false;
	public int difficulty;


	public float waitTime = 4f;
	
	private int rand;
	
	
	private RoomTemplates2 templates2;

	void Start(){
		
		
		difficulty = GameObject.FindGameObjectWithTag("RoomCounter").GetComponent<RoomCounter>().difficulty;
		
		//difficulty = 1;
		Destroy(gameObject, waitTime);
		templates = GameObject.FindGameObjectWithTag("RoomParts").GetComponent<RoomTemplates>();
		templates2 = GameObject.FindGameObjectWithTag("RoomParts2").GetComponent<RoomTemplates2>();

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
			
				
				if(openingDirection == 22){
					rand = Random.Range(0, templates2.b.Length);
					Instantiate(templates2.b[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 24){
					rand = Random.Range(0, templates2.l.Length);
					Instantiate(templates2.l[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 25){
					rand = Random.Range(0, templates2.inter.Length);
					Instantiate(templates2.inter[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 26){
					rand = Random.Range(0, templates2.ltr.Length);
					Instantiate(templates2.ltr[rand], transform.position, Quaternion.identity);
				} else if(openingDirection == 27){
					rand = Random.Range(0, templates2.r.Length);
					Instantiate(templates2.r[rand], transform.position, Quaternion.identity);
				}
				
				spawned = true;
			
			}
		}
	}

	
}
