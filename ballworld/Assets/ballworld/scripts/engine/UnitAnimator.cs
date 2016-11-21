public class UnitAnimator : Anim {    

    public void idle()
    {
        state = 0;
    }

    public void running()
    {
        state = 1;
    }

    public void strafing()
    {
        state = 2;
    }

    public void crossing()
    {
        state = 3;
    }

    public void crossingCW()
    {
        state = 4;
    }

    public void dying()
    {
        state = 5;
    }
}
