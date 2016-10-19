public class Unit : GameObject2D {

    public float speed = 0.05f;	

    public void run()
    {
        moveForward(speed);
    }

    public void strafeLeft()
    {
        moveSideways(-speed);
    }

    public void strafeRight()
    {
        moveSideways(speed);
    }

    public void runBackwards()
    {
        moveForward(-speed);
    }
}
