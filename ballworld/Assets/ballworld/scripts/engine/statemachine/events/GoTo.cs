using UnityEngine;

public class GoTo : UnitEvent {

    public Transform target;

    public override void happen()
    {
        unit.faceTowards(target);
        unit.runForward();
    }
}
