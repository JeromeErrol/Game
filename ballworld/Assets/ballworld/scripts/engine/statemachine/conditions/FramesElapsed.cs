
public class FramesElapsed : Condition {

    public int frames;
    private int current = 0;

    public override bool isMet()
    {
        return current++ > frames;
    }
}
