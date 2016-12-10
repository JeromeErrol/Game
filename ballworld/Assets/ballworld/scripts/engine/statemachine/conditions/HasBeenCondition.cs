using UnityEngine;

public class HasBeenCondition : Condition {

    public Condition condition;
    public bool hasBeenMet = false;

    public override bool isMet()
    {
        if (!hasBeenMet && condition.isMet())
        {
            hasBeenMet = true;
        }
        return hasBeenMet;
    }
}
