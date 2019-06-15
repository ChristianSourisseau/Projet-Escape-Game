using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tableau", menuName = "Objects/Obstacles/Tableau")]
public class Tableau : Obstacle
{
	
	[SerializeField]
	public PaintedNumber paintednumber;
	[SerializeField]
	private Door doorToOpen = null;
  
  [SerializeField]
  private GameObject[] numbers;
  
  [SerializeField]
  public int correctvalue;
  private int currentvalue;
  
  public static Tableau instance;
  
  public delegate void OnValueChanged();
  public OnValueChanged onValueChangedCallback;
  

    void Awake()
    {
        instance = this;
    }
  
  
  void Start() {
	  
		if(paintednumber != null){
			correctvalue = paintednumber.getInt();
		}
		else{
		Debug.LogError("paintednumber not initialize");
		}
		checkValue();
        this.onValueChangedCallback += checkValue;
  }
  
  
  private void checkValue() {
  	if (currentvalue == correctvalue ) {
    	doorToOpen.openDoor();
    }
    else {
    	doorToOpen.closeDoor();
    }
  }
  
  public void incrementValue() {
  	if (currentvalue != numbers.Length) {
    	currentvalue++;
    }
  }
  
  public void decrementValue() {
  	if (currentvalue != 0) {
    	currentvalue--;
    }
  }
  
}