using UnityEngine;

public abstract class GameAction : MonoBehaviour
{
    public abstract bool perform(BallworldObject ballworldObject);
}

