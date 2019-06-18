using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool affichCodeEnter = false;
    public static bool canvashinti = false;


    public GameObject pauseMenuUI;
    public GameObject codeEnter;
    public GameObject canvashint;

    void Start()
    {
        Resume();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            if (canvashint != null)
            {
                if (canvashinti)
                {
                    canvashint.SetActive(false);
                    canvashinti = false;
                }
                else
                {
                    canvashint.SetActive(true);
                    canvashinti = true;
                }
            }
           
        }



        if (Input.GetKeyDown("a"))
        {
            if (affichCodeEnter)
            {
                codeEnter.SetActive(false);
                affichCodeEnter = false;
            }
            else
            {
                codeEnter.SetActive(true);
                affichCodeEnter = true;
            }
        }



            if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    // bouton 
    public void QUIT_GAME()
    {
        Application.Quit();
    }

    public void BACK_TO_MENU()
    {
        SceneManager.LoadScene("Menu");
    }
  
}
