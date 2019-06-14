using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "A", menuName = "Objects/Hints/EnigmaElementA")]
public class EnigmaElementA : Hint
{
    [SerializeField]
    private int star;
    [SerializeField]
    private int sun;
    [SerializeField]
    private int moon;

    public override bool verifCode(int one, int two, int three, int four)
    {
        return false;
    }

    public int getStar()
    {
        return this.star;
    }

    public int getMoon()
    {
        return this.moon;
    }

    public int getSun()
    {
        return this.sun;
    }
}
