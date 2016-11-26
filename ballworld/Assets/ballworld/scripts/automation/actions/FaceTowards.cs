using UnityEngine;

public class FaceTowards : GameAction
{
    public Transform target;

    public override bool perform(BallworldObject ballworldObject)
    {
        ballworldObject.faceTowards(target.position);
        return true;
    }
}

