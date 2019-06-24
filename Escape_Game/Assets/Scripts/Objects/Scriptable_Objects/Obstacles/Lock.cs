using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "new Lock", menuName = "Objects/Obstacles/Lock")]
public class Lock : Obstacle
{
	
	public bool open = false;
	
   public override void  DoSomething(){
	   if(open){
		//SceneManager.LoadScene("Scenes/Salles");
	   }

   }
}
