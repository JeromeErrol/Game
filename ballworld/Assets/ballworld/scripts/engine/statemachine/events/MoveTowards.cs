using System;
using UnityEngine;

public class MoveTowards : GameEvent, Finishable{

    public Transform source;
    public Transform target;
    public float distance;

    public override void happen()
    {
        source.transform.RotateAround(Vector3.zero, Vector3.Cross(source.transform.position, target.transform.position), distance);
    }

    public bool isFinished()
    { 
        return Vector3.Distance(source.transform.position, target.transform.position) < distance;        
    }
}
