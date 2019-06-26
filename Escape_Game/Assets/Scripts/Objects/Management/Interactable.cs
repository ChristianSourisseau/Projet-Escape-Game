using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Interactable : MonoBehaviour
{
    public Item item;
    public Obstacle obstacle;
    public Hint hint;
	
	
	//
	public TextMeshProUGUI RoomText;
	public GameObject RoomCounter;
	
	void Start(){
		
		RoomCounter = GameObject.FindGameObjectWithTag("RoomCounter");
		RoomText = RoomCounter.GetComponent<TextMeshProUGUI>();
		
	}
	//


    public void Pickup()
    {
        Debug.Log("Picking up : " + item.name);
        if (Inventory.instance.Add(item))
        {
            Destroy(gameObject);
        }
    }

    public void useItemOnObject(Item item)
    {
       if (item.correctInteraction(obstacle))
        {
            Inventory.instance.remove(item);
			
			
			
			//
			RoomText.GetComponent<RoomCounter>().count = RoomText.GetComponent<RoomCounter>().count + 1;
			RoomText.text = "Room " + (RoomText.GetComponent<RoomCounter>().count ).ToString();
			
			if(RoomText.GetComponent<RoomCounter>().count > 3){
				
				if(RoomText.GetComponent<RoomCounter>().count <= 6){
				RoomText.GetComponent<RoomCounter>().difficulty = 2;
				}
				
				else if(RoomText.GetComponent<RoomCounter>().count > 6){
				RoomText.GetComponent<RoomCounter>().difficulty = 3;
				}
			}
			SceneManager.LoadScene("Scenes/Salles");
			//
			
			
			
			
        }
		
		

		
    }

    public void ShowHint()
    {
        gameObject.GetComponent<HintImage>().ShowHint();
    }
	
	public void interactObstacle()
    {
        obstacle.DoSomething();
    }
}
