using UnityEngine;

public class IsFacing : Condition {

    public Transform source;
    public Transform target;
    public float range;    

    public override bool isMet()
    {
        return Trig.approx(source.transform.rotation.eulerAngles.z, Trig.rotationBetween(source, target).eulerAngles.z, range);
    }
}
