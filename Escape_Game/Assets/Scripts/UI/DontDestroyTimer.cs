using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DontDestroyTimer : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("timer");

        if (objs.Length > 1)
        {
            Destroy(transform.gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
    }


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // here you can use scene.buildIndex or scene.name to check which scene was loaded
        if (scene.name == "Menu")
        {
            // Destroy the gameobject this script is attached to
            Destroy(transform.gameObject);
        }
        else if (scene.name == "GameOver")
        {
            Destroy(transform.gameObject);
        }
    }
}
