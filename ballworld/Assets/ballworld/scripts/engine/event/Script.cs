using UnityEngine;
using System.Collections;
using System;

public class Script : GameEvent {

    public String code;

    public override void happen()
    {
        ScriptRunner.Run(code);
    }
}
