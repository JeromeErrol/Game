using UnityEngine;

public class UnitGoTo : ConditionalGameEvent {

    public Unit unit;
    public Transform target;
    public bool faceTowards;


    public override void happen()
    {
        if (faceTowards)
        {
            unit.faceTowards(target);
        }
        unit.runForward();
    }

    public override bool isMet()
    {
        return Vector3.Distance(unit.transform.position, target.position) < 0.15f;
    }
}
