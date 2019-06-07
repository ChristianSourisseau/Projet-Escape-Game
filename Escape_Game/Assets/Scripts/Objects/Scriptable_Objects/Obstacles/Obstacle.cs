using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Obstacle : Objet
{
    public List<Objet> under = null;
    public List<Objet> inside = null;
    public List<Objet> ontop = null;
}
