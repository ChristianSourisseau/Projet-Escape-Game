using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public static DontDestroyOnLoad instance;
    private Scene scene;


    private void Awake()
    {
        //Verifies that there is only one instance of this script.
        if (instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }


    private void Start()
    {
        instance = this;
    }

    

    private void Update()
    {
        scene = SceneManager.GetActiveScene();

        //Verifies that this script is called in the right context
        if (!CorrectScene(scene))
        {
            GameObject.Destroy(gameObject);
        }
    }

    private bool CorrectScene(Scene scene)
    {
        return (scene.name == "Salles");
    }
}
