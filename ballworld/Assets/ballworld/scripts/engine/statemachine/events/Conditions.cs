using System.Collections.Generic;

public class Conditions : Condition {

    public List<Condition> conditions;    

    public override bool isMet()
    {
        foreach(Condition condition in conditions)
        {
            if (!condition.isMet())
            {
                return false;
            }
        }
        return true;
    }
}
