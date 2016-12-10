public class IsFinished : Condition {

    public Finishable finishable;

    public override bool isMet()
    {
        return finishable.isFinished();
    }
}
