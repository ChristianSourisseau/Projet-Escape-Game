using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void LOAD_GAME()
    {
        SceneManager.LoadScene("scenario");
    }

    public void QUIT_GAME()
    {
        Application.Quit();
    }

    public void LOAD_CREDIT()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LOAD_OPTION()
    {
        // SceneManager.LoadScene("salle103");  remplacer salle103 par la scene des options
    }

    //for come back to the menu
    public void BACK_TO_MENU()
    {
        SceneManager.LoadScene("Menu");
    }
}
