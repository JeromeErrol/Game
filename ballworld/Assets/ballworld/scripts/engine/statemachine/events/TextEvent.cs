
public class TextEvent : GameEvent {

    public string value;

    public override void happen()
    {
        TextUtil.set(value);
    }
}
