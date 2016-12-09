using UnityEngine;

public class IsFacing : Condition {

    public Transform source;
    public Transform target;
    public float range;    

    public override bool isMet()
    {
        return Trig.degreesBetween(source, target) < range;
    }
}
