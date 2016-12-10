using UnityEngine;
using System.Collections;

public class Log : GameEvent {

    public string message;

	public override void happen()
    {
        Debug.Log(gameObject.name + " " + message);
    }
}
