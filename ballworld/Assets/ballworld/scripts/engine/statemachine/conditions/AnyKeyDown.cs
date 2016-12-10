using UnityEngine;
using System.Collections;
using System;

public class AnyKeyDown : Condition {

    public override bool isMet()
    {
        return Input.anyKeyDown;
    }
}
