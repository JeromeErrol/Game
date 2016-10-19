public class Unit : BallworldObject {

    public float runSpeed = 0.3f;
    public bool boost = false;
    public float boostAmount = 1.1f;

    public float Speed
    {
        get
        {
            if (boost)
            {
                return runSpeed * boostAmount;
            }
            return runSpeed;
        }
    }

    public void runForward()
    {
        moveForward(Speed);
    }

    public void runBackward()
    {
        moveForward(-Speed);
    }

    public void strafeLeft()
    {
        moveSideways(-Speed);
    }

    public void strafeRight()
    {
        moveSideways(Speed);
    }
}
