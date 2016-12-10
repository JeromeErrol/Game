using System;
using UnityEngine;

public class RunForward : UnitEvent {
    
    public Transform target;

    public override void happen()
    {
        unit.runForward();
    }
}
