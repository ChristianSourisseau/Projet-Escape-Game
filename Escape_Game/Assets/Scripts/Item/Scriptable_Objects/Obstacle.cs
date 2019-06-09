using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Obstacle : Objet
{
    public List<Item> under = null;
    public List<Item> inside = null;
    public List<Item> ontop = null;
}
