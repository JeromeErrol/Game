using UnityEngine;
using System.Collections;

public class SomeEvent : GameEvent {

    public string message;

	public override void happen()
    {
        Debug.Log(message);
    }
}
