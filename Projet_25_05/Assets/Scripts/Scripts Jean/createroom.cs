using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createroom : MonoBehaviour
{
	public GameObject T = null;
	public GameObject B = null;
	public GameObject R = null;
	public GameObject L = null;

    // Start is called before the first frame update
    void Start()
    {
		Instantiate(R,transform.position,Quaternion.identity);
		Instantiate(R,transform.position,Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
