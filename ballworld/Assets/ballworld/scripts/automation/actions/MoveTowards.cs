
using UnityEngine;

public class MoveTowards : GameAction {
    
    public float speed;
    public Transform target;

    public override bool perform(BallworldObject ballworldObject)
    {
        if (Vector3.Distance(target.position, ballworldObject.transform.position) > 0.01f) {
            ballworldObject.moveTowards(target.position, speed);
            return false;
        }
        return true;
    }
}
