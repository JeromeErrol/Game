using UnityEngine;
using System.Collections;

public class SetMovementLock : GameEvent {

    public bool value;

    public override void happen()
    {
        UnitController.instance.lockMovement = value;
    }
}
