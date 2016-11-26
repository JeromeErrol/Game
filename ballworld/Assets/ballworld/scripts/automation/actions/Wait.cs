
using System;
using UnityEngine;

public class Wait : GameAction
{
    public int frames;
    private int current = 0;

    public override bool perform(BallworldObject ballworldObject)
    {
        if (current++ >= frames)
        {
            current = 0;
            return true;
        }
        return false;
    }
}
