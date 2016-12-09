using UnityEngine;
using System.Collections;
using System;

public class AwaitingMouse : Condition {

    public float accelerationX;


    public override bool isMet()
    {
        Debug.Log(IO.MouseX);
        return IO.MouseX < -accelerationX;
    }
}
