using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGo : MonoBehaviour
{
    public GameObject play;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            
        }
    }

}
