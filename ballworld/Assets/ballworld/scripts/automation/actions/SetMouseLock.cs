using UnityEngine;
using System.Collections;
using System;

public class SetMouseLock : GameEvent
{
    public bool value;

    public override void happen()
    {
        UnitController.instance.lockMouse = value;
    }
}
