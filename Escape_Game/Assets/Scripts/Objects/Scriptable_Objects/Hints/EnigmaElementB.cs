using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "B", menuName = "Objects/Hints/EnigmaElementB")]
public class EnigmaElementB : Hint
{

    [SerializeField]
    private int starPos;
    [SerializeField]
    private int sunPos;
    [SerializeField]
    private int moonPos;

    public override bool verifCode(int one, int two, int three, int four)
    {
        return false;
    }

    public int getStarPos()
    {
        return this.starPos;
    }

    public int getMoonPos()
    {
        return this.moonPos;
    }

    public int getSunPos()
    {
        return this.sunPos;
    }

}
