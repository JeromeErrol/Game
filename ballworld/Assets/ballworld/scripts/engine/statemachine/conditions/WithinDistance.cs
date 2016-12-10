using System;
using UnityEngine;

public class WithinDistance : Condition {

    public Transform source;
    public Transform target;
    public float distance;    

    public override bool isMet()
    {
        float distance = Vector3.Distance(source.position, target.position);
        float remainder = this.distance - distance;
        Debug.Log("Distance remaining: " + remainder);
        return remainder > 0;
    }
}
