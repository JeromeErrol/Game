using UnityEngine;
using System.Collections;
using System;

public class KeyIsDown : Condition {

    public KeyCode keyCode;

    public override bool isMet()
    {
        return Input.GetKeyDown(keyCode);
    }   
}
