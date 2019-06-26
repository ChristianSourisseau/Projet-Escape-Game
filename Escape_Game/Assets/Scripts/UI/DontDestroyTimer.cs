using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}