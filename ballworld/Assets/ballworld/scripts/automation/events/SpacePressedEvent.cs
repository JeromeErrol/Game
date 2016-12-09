using UnityEngine;
using System.Collections;
using System;

public class GetKeyDown : Condition {

    public KeyCode keyCode;

    public override bool isMet()
    {
        return Input.GetKeyDown(keyCode);
    }

    
        
}
