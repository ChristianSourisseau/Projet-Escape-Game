using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public Text text;
    public float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        text.text = Mathf.Floor(timeLeft / 60).ToString("00") + ":" + Mathf.FloorToInt(timeLeft % 60).ToString("00");

    }

    // Update is called once per frame
    void Update()
    {
       
        timeLeft -= Time.deltaTime;
        text.text = Mathf.Floor(timeLeft / 60).ToString("00") + ":" + Mathf.FloorToInt(timeLeft % 60).ToString("00");
        if(text.text == "00:00")
        {
            SceneManager.LoadScene("Menu");
        }
    }


}
