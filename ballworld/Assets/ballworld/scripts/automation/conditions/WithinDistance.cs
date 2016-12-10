using UnityEngine;

public class WithinDistance : Condition {

    public Transform source;
    public Transform target;
    public float distance;

    public override bool isMet()
    {
        return Vector3.Distance(source.position, target.position) < distance;
    }
}
