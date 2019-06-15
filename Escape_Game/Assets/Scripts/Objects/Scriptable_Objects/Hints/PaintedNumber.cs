using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Painted Number", menuName = "Objects/Hints/Painted_Number")]
public class PaintedNumber : Hint
{
    [SerializeField]
    private int value;

public virtual bool verifCode(int one, int two, int three, int four)
    {
        return false;
    }
	
	public int getInt() {
    return this.value;
}
}