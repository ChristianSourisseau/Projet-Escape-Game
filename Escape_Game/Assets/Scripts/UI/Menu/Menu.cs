using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void LOAD_GAME()
    {
        SceneManager.LoadScene("room001");
    }

    public void QUIT_GAME()
    {
        Application.Quit();
    }

    public void LOAD_CREDIT()
    {
       // SceneManager.LoadScene("salle103"); remplacer salle103 par la scene des credits
    }

    public void LOAD_OPTION()
    {
        // SceneManager.LoadScene("salle103");  remplacer salle103 par la scene des options
    }
}
