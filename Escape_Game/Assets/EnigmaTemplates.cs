using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaTemplates : MonoBehaviour
{
	
	public GameObject[] shelf;
	public GameObject[] door;

	
    public List<GameObject> shelfdoor;
	private int rand;
	
	
	void Start(){
		Invoke("SpawnShelfDoor", 0.3f);
	}
	
	void SpawnShelfDoor(){
		rand = Random.Range(0, shelfdoor.Count);
		Instantiate(door[0],shelfdoor[rand].transform.position, Quaternion.identity);

		for(int i = 0; i < shelfdoor.Count; i++){
			if( i != rand){
				Instantiate(shelf[0],shelfdoor[i].transform.position, Quaternion.identity);
			}

		}
		
	}
}
