using UnityEngine;
using System.Collections;
using System;

public class SetActive : GameEvent
{
    public GameObject target;
    public bool value;

    public override void happen()
    {
        target.SetActive(value);
    }
}
