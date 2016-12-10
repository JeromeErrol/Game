using System;
using UnityEngine;

public class MoveTowards : ConditionalGameEvent {

    public Transform source;
    public Transform target;
    public float distance;

    public override void happen()
    {
        source.transform.RotateAround(Vector3.zero, Vector3.Cross(source.transform.position, target.transform.position), distance);
    }

    public override bool isMet()
    {
        return Vector3.Distance(source.transform.position, target.transform.position) < distance;
    }
}
