using System.Collections.Generic;

public class ActionCycle : GameAction
{
    public List<GameAction> actions;
    public int index = 0;
    private BallworldObject ballworldObject;

    void Start()
    {
        ballworldObject = GetComponent<BallworldObject>();
    }

    public override bool perform(BallworldObject ballworldObject)
    {
        GameAction action = actions[index];
        if (action.perform(ballworldObject))
        {
            index = (index + 1) % actions.Count;
        }
        return false;
    }

    void Update()
    {
        perform(ballworldObject);
    }
}
