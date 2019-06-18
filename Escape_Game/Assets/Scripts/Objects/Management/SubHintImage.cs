using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubHintImage : HintImage
{
    [SerializeField]
    HintImage hi;

    protected override void Start()
    {
        r = null; // safety net
        hi = HintImage.instance;
        hi.onHintChangedCallback += base.Start;
    }
}
