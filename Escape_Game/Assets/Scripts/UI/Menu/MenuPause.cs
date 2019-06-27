using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    private AudioSource music;

    void Start()
    {
        Resume();
        music = FindObjectOfType<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                if (music != null)
                {
                    music.UnPause();
                }
            }
            else
            {
                Pause();
                if (music != null)
                {
                    music.Pause();
                }
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
