using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaTemplates : MonoBehaviour
{
	
	public GameObject[] shelf;
	public GameObject[] door;
	
	public GameObject[] key;
	public GameObject[] plant;
	
	public GameObject[] number;
	public GameObject[] sign;
	
	public GameObject[] statue;




	
    public List<GameObject> shelfdoor;
	public List<GameObject> keyplant;
	
	
	private int randsce;
	private int nrbsce;
	
	private int randpos;
	private int rand1;
	private int rand2;
	
	


	
	
	void Start(){
		
		nrbsce = 2;
		randsce = Random.Range(0, nrbsce);
		Debug.Log(randsce);
		
		if( randsce == 0){
			
			Invoke("Scena1", 0.3f);
		}
		if( randsce == 1){
			
			Invoke("Scena2", 0.3f);
		}

		

	}
	void Scena1(){
		//SpawnShelfDoor
		randpos = Random.Range(0, shelfdoor.Count);
		rand1 = Random.Range(0, door.Length);
		
		Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity);

		for(int i = 0; i < shelfdoor.Count; i++){
			if( i != randpos){
				
				rand2 = Random.Range(0, shelf.Length);
				
				if(Random.Range(0, 2) == 1){
					Instantiate(shelf[rand2],shelfdoor[i].transform.position, Quaternion.identity);
				}
				
			}

		}
		
		//SpawnKeyPlant()
		randpos = Random.Range(0, keyplant.Count);
		rand1 = Random.Range(0, key.Length);

		Instantiate(key[rand1],keyplant[randpos].transform.position, Quaternion.identity);

		for(int i = 0; i < keyplant.Count; i++){
			if( i != randpos){
				
				rand2 = Random.Range(0, plant.Length);
				
				if(Random.Range(0, 2) == 1){
					Instantiate(plant[rand2],keyplant[i].transform.position, Quaternion.identity);
				}
			}

		}
		
	}
	
	void Scena2(){
		
		//SpawnShelfDoor
		randpos = Random.Range(0, shelfdoor.Count);
		rand1 = Random.Range(0, number.Length);
		
		Instantiate(number[rand1],shelfdoor[randpos].transform.position, Quaternion.identity);
		int randnumberpos = randpos;
		while(randnumberpos == randpos){
			randpos = Random.Range(0, shelfdoor.Count);
		}
		
		rand1 = Random.Range(0, door.Length);
		Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity);


		for(int i = 0; i < shelfdoor.Count; i++){
			if( i != randpos && i != randnumberpos){
				
				rand2 = Random.Range(0, shelf.Length);
				
				if(Random.Range(0, 2) == 1){
					Instantiate(shelf[rand2],shelfdoor[i].transform.position, Quaternion.identity);
				}
			}

		}
		
		
		//SpawnKeyPlant()
		randpos = Random.Range(0, keyplant.Count);
		rand1 = Random.Range(0, sign.Length);

		Instantiate(sign[rand1],keyplant[randpos].transform.position, Quaternion.identity);

		for(int i = 0; i < keyplant.Count; i++){
			if( i != randpos){
				
				rand2 = Random.Range(0, statue.Length);
				
				if(Random.Range(0, 2) == 1){
					Instantiate(statue[rand2],keyplant[i].transform.position, Quaternion.identity);
				}
			}

		}
		
		
		
	}
}
