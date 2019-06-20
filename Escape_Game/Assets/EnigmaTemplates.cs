﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaTemplates : MonoBehaviour
{
	
	//general
	public List<GameObject> shelfdoor;
	public List<GameObject> keyplant;
	
	public GameObject[] door;

	public GameObject[] shelf;
	
	public int scena;
	private int nrbsce;
	
	private int randpos;
	private int rand1;
	private int rand2;
	
	
	
	
	//scena1
	public GameObject[] key;
	public GameObject[] plant;


	
	//scena2
	public GameObject[] statue;
	public GameObject[] sign;
	public GameObject[] board;
	public GameObject[] rednumbers;
	public GameObject[] whitenumbers;
	
	public GameObject Owhitenumber;
	
	public int whitenumber;
	public int rednumber;

	
	//scena3
	public GameObject[] pressure;
	public GameObject[] cube;
	public GameObject[] hospitaldecowall;
	public GameObject[] hospitaldecoground;






	


	
	
	void Start(){
		
		nrbsce = 3;
		//scena = Random.Range(0, nrbsce);
		scena = 2;
		Debug.Log(scena);
		
		if( scena == 0){
			
			Invoke("Scena1", 0.3f);
		}
		if( scena == 1){
			
			Invoke("Scena2", 0.3f);
		}
		if( scena == 2){
			
			Invoke("Scena3", 0.3f);
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
		rednumber = Random.Range(0, rednumbers.Length);
		Instantiate(rednumbers[rednumber],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn rednumber
		shelfdoor.Remove(shelfdoor[randpos]);

		
		randpos = Random.Range(0, shelfdoor.Count);
		rand1 = Random.Range(0, door.Length);
		Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn door
		shelfdoor.Remove(shelfdoor[randpos]);



		for(int i = 0; i < shelfdoor.Count; i++){
		
			rand1 = Random.Range(0, shelf.Length);
			
			if(Random.Range(0, 2) == 1){
				Instantiate(shelf[rand1],shelfdoor[i].transform.position, Quaternion.identity); //Spawn shelf
			}
			

		}
		
		
		//SpawnKeyPlant
		randpos = Random.Range(0, keyplant.Count);
		Instantiate(sign[0],keyplant[randpos].transform.position, Quaternion.identity); //Spawn sign +
		keyplant.Remove(keyplant[randpos]);

		randpos = Random.Range(0, keyplant.Count);
		Instantiate(sign[1],keyplant[randpos].transform.position, Quaternion.identity); //Spawn sign -
		keyplant.Remove(keyplant[randpos]);
		
		randpos = Random.Range(0, keyplant.Count);
		Instantiate(board[0],keyplant[randpos].transform.position, Quaternion.identity); //Spawn board
		
		whitenumber = Random.Range(0, whitenumbers.Length);
		Owhitenumber = Instantiate(whitenumbers[whitenumber],keyplant[randpos].transform.position, Quaternion.identity); //Spawn whitenumber
		keyplant.Remove(keyplant[randpos]);



		

		for(int i = 0; i < keyplant.Count; i++){
		
			rand1 = Random.Range(0, statue.Length);
			
			if(Random.Range(0, 2) == 1){
				Instantiate(statue[rand1],keyplant[i].transform.position, Quaternion.identity); //Spawn statue
			}
			

		}
		
		
		
	}
	
	void Scena3(){
		
		//SpawnShelfDoor
		randpos = Random.Range(0, shelfdoor.Count);
		rand1 = Random.Range(0, door.Length);
		Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn door
		shelfdoor.Remove(shelfdoor[randpos]);
		
		
		//SpawnKeyPlant
		randpos = Random.Range(0, keyplant.Count);
		Instantiate(pressure[0],keyplant[randpos].transform.position, Quaternion.identity); //Spawn pressure plate
		keyplant.Remove(keyplant[randpos]);
		
		randpos = Random.Range(0, keyplant.Count);
		Instantiate(cube[0],keyplant[randpos].transform.position, Quaternion.identity); //Spawn cube
		keyplant.Remove(keyplant[randpos]);
		

		for(int i = 0; i < keyplant.Count; i++){
		
			rand1 = Random.Range(0, hospitaldecoground.Length);
			
			if(Random.Range(0, 2) == 1){
				Instantiate(hospitaldecoground[rand1],keyplant[i].transform.position, Quaternion.identity); //Spawn hospitaldecoground
			}
			

		}
		
	}
}
