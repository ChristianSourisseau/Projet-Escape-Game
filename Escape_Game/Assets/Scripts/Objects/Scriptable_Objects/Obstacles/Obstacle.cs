using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Obstacle : Objet
{
    public GameObject obj;

    public virtual void DoSomething() {
    	//method to override
    }

    public void Init(GameObject o)
    {
        this.obj = o;
    }

}
