using UnityEngine;

public class MoveTowards : Action
{
    public Transform target;
    public float speed;
    public Transition finishEvent;

    public override void perform()
    {
        ballworldObject.moveTowards(target.position, speed);
    }

    public override bool isFinished()
    {
        return Vector3.Distance(ballworldObject.transform.position, target.position) < speed;
    }
}
