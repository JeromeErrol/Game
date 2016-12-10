using UnityEngine;
using System.Collections;
using System;

public class ApplicationQuit : GameEvent {
    public override void happen()
    {
        Debug.Log("APPLICATION.QUITTING");
        Application.Quit();
    }
}
