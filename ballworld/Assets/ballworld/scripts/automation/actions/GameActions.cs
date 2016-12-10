using System.Collections.Generic;

public class GameActions : GameEvent {

    public List<GameEvent> events;

    public override void happen()
    {
        foreach(GameEvent gameEvent in events)
        {
            gameEvent.happen();
        }
    }
}
