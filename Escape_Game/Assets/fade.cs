using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(true);
    }


    public void end()
    {
        img.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
