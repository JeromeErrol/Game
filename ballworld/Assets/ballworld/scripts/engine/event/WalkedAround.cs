using UnityEngine;
using System.Collections;
using System;

public class WalkedAround : Condition {

    public Transform source;
    public Transform target;
    public float degrees;
    private float degreesCovered;
    private float previous = START;
    private const float START = 0.0000191f;

    public override bool isMet()
    {
        float current = Trig.degreesBetween(source, target.transform);
        if (previous == START)
        {
            previous = current;
        }
        float difference = Trig.degreesDifference(previous, current);
        previous = current;
        Debug.Log(difference + " " + degreesCovered);

        if (Mathf.Abs(difference) < 10)
        {
            degreesCovered += difference;
        }
        return Mathf.Abs(degreesCovered) >=Mathf.Abs(degrees);
    }
}
