using UnityEngine;

public class RunForward : UnitEvent {

    public Unit unit;
    public Transform target;

    public override void happen()
    {
        unit.faceTowards(transform);
        unit.runForward();
    }
}
