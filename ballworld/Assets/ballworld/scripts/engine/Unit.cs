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

    public void standStill()
    {
        GetComponent<RunAnimation>().running = false;
    }

    public void runForward()
    {
        moveForward(Speed);
        GetComponent<RunAnimation>().running = true;
    }

    public void runBackward()
    {
        moveForward(-Speed);
        GetComponent<RunAnimation>().running = true;
    }

    public void strafeLeft()
    {
        moveSideways(-Speed);
        GetComponent<RunAnimation>().running = true;
    }

    public void strafeRight()
    {
        moveSideways(Speed);
        GetComponent<RunAnimation>().running = true;
    }
}
