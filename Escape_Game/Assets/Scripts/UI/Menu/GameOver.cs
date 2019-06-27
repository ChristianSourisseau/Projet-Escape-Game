using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void TRY_AGAIN()
    {
        SceneManager.LoadScene("scenario");
    }

    public void QUIT_GAME()
    {
        Application.Quit();
    }

    //for come back to the menu
    public void BACK_TO_MENU()
    {
        SceneManager.LoadScene("Menu");
    }
}
