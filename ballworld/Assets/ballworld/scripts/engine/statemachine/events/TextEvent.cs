
using System;

public class TextEvent : ConditionalGameEvent {

    public string value;
    private string valuePrint = "";

    public override void happen()
    {
        if (value.Length > 0)
        {
            valuePrint = value.Substring(0, valuePrint.Length + 1);
        }else
        {
            valuePrint = value;
        }
          TextUtil.set(valuePrint);
    }

    public override bool isMet()
    {
        return valuePrint.Length == value.Length;
    }
}
