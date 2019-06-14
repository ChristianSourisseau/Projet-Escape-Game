using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubHintImage : HintImage
{
    HintImage hi;

    protected override void Start()
    {
        hi = HintImage.instance;
        hi.onHintChangedCallback += base.Start;
    }
}
