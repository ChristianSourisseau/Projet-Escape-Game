using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Door", menuName = "Objects/Obstacles/Door")]
public class Door : Obstacle
{
    public string sceneToLoad = "NOM DE TA SCENE";

    bool isOpen = false;

    public void openDoor() {
        //Faire quelquechose
        //par exemple changer le sprite a une porte ouverte et faire en sorte qu'on puisse passer a travers maintenant.

        isOpen = true;
}

	public void closeDoor() {
        //fermer la porte (a toi de voir l'implementation)

        isOpen = false;
}



    public override void DoSomething()
    {
        //ICI CHARGER NOUVELLE SCENE
       // SceneManager.LoadScene(sceneToLoad);
    }
}
