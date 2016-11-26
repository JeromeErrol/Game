
public class Gate : BallworldObject {

    public float speed = 0.1f;
    public float distance = 2;

    public GateState state = GateState.IDLE;
    private float distanceOpened;

    public enum GateState
    {
        IDLE, OPENING, CLOSING
    };
	
	void Update () {
        switch (state)
        {
            case GateState.OPENING:
                if (distanceOpened >= distance)
                {
                    state = GateState.IDLE;
                }
                else
                {
                    distanceOpened += speed;
                    moveSideways(speed);
                }
                break;
            case GateState.CLOSING:
                if (distanceOpened <=  0)
                {
                    state = GateState.IDLE;
                }
                else
                {
                    distanceOpened -= speed;
                    moveSideways(-speed);
                }
                break;
        }  
    }
}
