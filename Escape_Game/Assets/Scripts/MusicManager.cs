using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    private string currentscenename;
    private string previousscenename;

    [SerializeField]
    private AudioSource goost;

    [SerializeField]
    private AudioClip[] ost;


    private delegate void onSceneChanged();
    private onSceneChanged SceneChanged;

    private void Awake()
    {
        currentscenename = "Menu";
        SceneChanged += ChangeMusic;

        goost = gameObject.GetComponent<AudioSource>();
        if (instance != null)
        {
            GameObject.Destroy(gameObject);
            return;
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
        string activescene = SceneManager.GetActiveScene().name;
        if (!currentscenename.Equals(activescene))
        {
            previousscenename = currentscenename;
            currentscenename = activescene;
            if (SceneChanged != null)
                SceneChanged.Invoke();
        }
    }

    private void ChangeMusic()
    {
        switch (currentscenename)
        {
            case "Menu":
                if (!previousscenename.Equals("Settings") && !previousscenename.Equals("Credits"))
                {
                    goost.Stop();
                    goost.PlayOneShot(ost[0]);
                }
                break;
            case "Salles":
                goost.Stop();
                goost.PlayOneShot(ost[1]);
                break;
            default: break;
        }
    }

}
