using UnityEngine;
using System.Collections;
using System;

public class Log : GameEvent {

    public string message;

	public override void happen()
    {
        Debug.Log(gameObject.name + " " + message);
    }

    public override bool isMet()
    {
        return true;
    }
}
