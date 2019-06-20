using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;

    private bool hasPlayer = false;
    private bool beingCarried = false;
	
	void Start(){
		
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();

	}
	
	
	
	void OnTriggerEnter2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		hasPlayer = true;
		}
	}
	
	void OnTriggerExit2D (Collider2D player)
	{
        if (player.gameObject.tag == "Player") 
        {
		hasPlayer = false;			
		}
	}

    void Update()
    {
        

        // if we can pick up and press E = we carry the object
        if (hasPlayer && Input.GetKey(KeyCode.E))
        {
            transform.parent = playerCam;
            beingCarried = true;
        }

        // if we carry the object and press E = we put the object
        if (beingCarried && Input.GetKey(KeyCode.A))
        {
			transform.parent = null;
			beingCarried = false;
		}
    }
    
	
	
	
}