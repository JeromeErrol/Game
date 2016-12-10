using UnityEngine;

public class Face : UnitEvent
{
    public Transform target;

    public override void happen()
    {
        unit.faceTowards(target);
    }
}
