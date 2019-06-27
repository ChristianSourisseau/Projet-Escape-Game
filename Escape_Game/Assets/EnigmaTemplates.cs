using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaTemplates : MonoBehaviour
{
	
	//general
	public List<GameObject> shelfdoor;
	public List<GameObject> keyplant;
	public List<GameObject> bigoffice;
	
	public List<GameObject> shelfdoor2;
	public List<GameObject> keyplant2;
	

	
	public List<GameObject> player;
	
	public GameObject GameObjectPlayer;


	
	
	public GameObject[] door;
	
	public GameObject[] office;

	public GameObject[] shelf;
	
	public int scena;
	private int nrbsce;
	
	private int randpos;
	private int rand1;
	private int rand2;

	public GameObject eclat;
	
	public int difficulty;


	
	
	
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

	//scena4
	public List<GameObject> listposlaser;
	public GameObject laser;
	
	public GameObject dellaser;
	
	public bool laserbool;
	
	//scena5
	
	public List<GameObject> tubinglist;
	public GameObject[] tubing;
	
	public List<GameObject> walllist;
	public GameObject[] walls;
	
	//scena6 (dessin)
	
	public List<GameObject> listhint;
	public GameObject[] hints;

	public List<GameObject> listcadenas;
	public List<GameObject> cadenas;


	private GameObject hint;
	public GameObject cadena; 
	
	public GameObject digicode;
	public GameObject laserdigicode;
	
	public GameObject laserdigicodetemp;
	
	public Cadena ca;



	//scena7
	
	public List<GameObject> listboxes;
	public GameObject[] boxes;
	
	//scena8 (floor decoration)

	public List<GameObject> listfloor;
	public GameObject[] floor;
	
	//scena9 (codag)
	
	
	public List<GameObject> listhintcodag;
	public GameObject[] hintscodag;
	
	public List<GameObject> listcadenas2;


	private GameObject hintcodag;
	public GameObject cadena2; 

	public GameObject laserdigicode2;

	
	public GameObject laserdigicodetemp2;
	
	// scena 10 (riddle)
	
	public List<GameObject> listhintriddle;
	public GameObject[] hintsriddle;
	
	public List<GameObject> listcadenas3;


	private GameObject hintriddle;
	public GameObject cadena3; 

	public GameObject laserdigicode3;

	
	public GameObject laserdigicodetemp3;
	

	






	


	
	
	void Start(){
		
		
		nrbsce = 3;
		scena = Random.Range(0, nrbsce);
		//scena = 1 ;
		
		
		difficulty = GameObject.FindGameObjectWithTag("RoomCounter").GetComponent<RoomCounter>().difficulty;
		laserbool = false;

		

		if(difficulty == 1){
			if( scena == 0){
				
				Invoke("Scena1", 1f);
			}
			if( scena == 1){
				
				Invoke("Scena2", 1f);
			}
			if( scena == 2){
				
				Invoke("Scena3", 1f);
			}
		}
		else if( difficulty >= 2){
			scena = 4;
			Invoke("Scena4", 1f);
		}
		


		

	}
	void Scena1(){
		
		//SpawnOffice

		for(int i = 0; i < bigoffice.Count; i++){
			
			rand1 = Random.Range(0, office.Length);
			
			Instantiate(office[rand1],bigoffice[i].transform.position, Quaternion.identity);
			
		
		}

		//SpawnShelfDoor
		
		if(!laserbool){
			randpos = Random.Range(0, shelfdoor.Count);
			rand1 = Random.Range(0, door.Length);
			
			Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity);
			
		}

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
		if(!laserbool){
			
			randpos = Random.Range(0, shelfdoor.Count);
			rand1 = Random.Range(0, door.Length);
			Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn door
			shelfdoor.Remove(shelfdoor[randpos]);
			
		}
			
		randpos = Random.Range(0, shelfdoor.Count);
		rednumber = Random.Range(0, rednumbers.Length);
		Instantiate(rednumbers[rednumber],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn rednumber
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
		if(!laserbool){
			randpos = Random.Range(0, shelfdoor.Count);
			rand1 = Random.Range(0, door.Length);
			Instantiate(door[rand1],shelfdoor[randpos].transform.position, Quaternion.identity); //Spawn door
			shelfdoor.Remove(shelfdoor[randpos]);
		}
		
		
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
	
	
	void Scena4(){
		
		//Spawnlaser
		laserbool = true;
		if(listposlaser.Count > 0){
			dellaser = Instantiate(laser,listposlaser[0].transform.position, Quaternion.identity); //Spawn laser
			listposlaser.Remove(listposlaser[0]);
		}
		
		scena = Random.Range(41, 43);
		if(scena == 41){
			Scena2();
		}
		else if(scena == 42){
			Scena3();
		}
		
		
		shelfdoor = shelfdoor2;
		keyplant = keyplant2;
		laserbool = false;
		
		Scena1();
		
		Scena7();
		Scena5();
		
		Scena8();
		Scena9();
		Scena10();


		
	}
	
	void Scena5(){ // dessin
		
		
		
		//SpawnHint
		
		
		if(listhint.Count > 0){
			
			randpos = Random.Range(0, listhint.Count);
			hint = Instantiate(hints[0],listhint[randpos].transform.position, Quaternion.identity); //Spawn hint
			listhint.Remove(listhint[randpos]);
			
		
		
		
		
		
			randpos = Random.Range(0, listcadenas.Count);
			rand1 = Random.Range(0, cadenas.Count);

			Instantiate(digicode,listcadenas[randpos].transform.position, Quaternion.identity); //Spawn sprite digicode
			cadena = Instantiate(cadenas[rand1],listcadenas[randpos].transform.position, Quaternion.identity); //Spawn cadenas
			
			
			
			laserdigicodetemp = Instantiate(laserdigicode,cadena.transform.position, Quaternion.identity) as GameObject; //Spawn gameobject laserdigicode
	
		

			cadena.GetComponent<Cadena>().h = hint.GetComponent<Interactable>().hint;
			
			cadenas.Remove(cadenas[rand1]);
			listcadenas.Remove(listcadenas[randpos]);
			
		}
		
		
	
	}
	
	void Scena7(){
		//Spawnwalls
		if(walllist.Count > 0){
			randpos = Random.Range(0, walllist.Count);
			Instantiate(walls[1],walllist[randpos].transform.position, Quaternion.identity); //Spawn walllaser
			walllist.Remove(walllist[randpos]);
		}
		
		for(int i = 0; i < walllist.Count; i++){
			
			
			
			Instantiate(walls[0],walllist[i].transform.position, Quaternion.identity);
			// if(Random.Range(0, 2) != 0){
				// Instantiate(walls[0],walllist[i].transform.position, Quaternion.identity);
			// }
			// else{
				// Instantiate(walls[1],walllist[i].transform.position, Quaternion.identity);
			// }
		}
		
		//Spawnboxes
		
		
		for(int i = 0; i < listboxes.Count; i++){
			
			
			rand1 = Random.Range(0, shelf.Length);
			
			if(Random.Range(0, 3) != 0){
				Instantiate(boxes[rand1],listboxes[i].transform.position, Quaternion.identity);
			}
		
			
		}
		
		
		
	}
	
	void Scena8(){
		
		//Spawn floor decoration
		for(int i = 0; i < listfloor.Count; i++){
			
			
			rand1 = Random.Range(0, floor.Length);
			
			if(Random.Range(0, 2) != 0){
				Instantiate(floor[rand1],listfloor[i].transform.position, Quaternion.identity); 
			}
		
			
		}
	
	}
	
 
	void  Scena9(){ //codag
	
	
		//SpawnHint
		
		
		if(listhintcodag.Count > 0){
			
			randpos = Random.Range(0, listhintcodag.Count);
			rand1 = Random.Range(0, hintscodag.Length);

			hintcodag = Instantiate(hintscodag[rand1],listhintcodag[randpos].transform.position, Quaternion.identity); //Spawn hint
			listhintcodag.Remove(listhintcodag[randpos]);
			
		
			
			randpos = Random.Range(0, listcadenas.Count);
			rand1 = Random.Range(0, cadenas.Count);

			Instantiate(digicode,listcadenas[randpos].transform.position, Quaternion.identity); //Spawn sprite digicode
			cadena2 = Instantiate(cadenas[rand1],listcadenas[randpos].transform.position, Quaternion.identity); //Spawn cadenas
			
			
			
			laserdigicodetemp2 = Instantiate(laserdigicode2,cadena2.transform.position, Quaternion.identity) as GameObject; //Spawn gameobject laserdigicode 
			

			cadena2.GetComponent<Cadena>().h = hintcodag.GetComponent<Interactable>().hint;
			
			cadenas.Remove(cadenas[rand1]);
			listcadenas.Remove(listcadenas[randpos]);
			
		}
		
	}
	
	void  Scena10(){ //riddle
	
	if(listhintriddle.Count > 0){
			
			randpos = Random.Range(0, listhintriddle.Count);
			rand1 = Random.Range(0, hintsriddle.Length);

			hintriddle = Instantiate(hintsriddle[rand1],listhintriddle[randpos].transform.position, Quaternion.identity); //Spawn hint
			listhintriddle.Remove(listhintriddle[randpos]);
			
		
			
			randpos = Random.Range(0, listcadenas.Count);
			rand1 = Random.Range(0, cadenas.Count);

			Instantiate(digicode,listcadenas[randpos].transform.position, Quaternion.identity); //Spawn sprite digicode
			cadena3 = Instantiate(cadenas[rand1],listcadenas[randpos].transform.position, Quaternion.identity); //Spawn cadenas
			
			
			
			laserdigicodetemp3 = Instantiate(laserdigicode3,cadena3.transform.position, Quaternion.identity) as GameObject; //Spawn gameobject laserdigicode 
			

			cadena3.GetComponent<Cadena>().h = hintriddle.GetComponent<Interactable>().hint;
			
			cadenas.Remove(cadenas[rand1]);
			listcadenas.Remove(listcadenas[randpos]);
			
		}
	
	}
}
