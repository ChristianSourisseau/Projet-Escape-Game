using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    private void Awake()
    {
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



}
