using UnityEngine;
using System.Collections.Generic;

public class State : MonoBehaviour {

    public void process(EventEnum eventEnum)
    {
        foreach (StateEvent stateEvent in new List<StateEvent>(GetComponents<StateEvent>()))
        {
            if (stateEvent.eventEnum == eventEnum)
            {
                Condition condition = null;

                if(stateEvent is ConditionalStateEvent)
                {
                    condition = ((ConditionalStateEvent)stateEvent).condition;
                }
                if(condition == null || condition.isMet())
                {
                    stateEvent.gameEvent.happen();
                }
            }
        }
    }
}
