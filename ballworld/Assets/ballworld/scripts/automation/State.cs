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
                if(stateEvent.gameEvent != null && condition == null || condition.isMet())
                {
                    stateEvent.gameEvent.happen();
                }else
                {
                    throw new UnityException(stateEvent.name + " gameEvent is null");
                }
            }
        }
    }

    void OnValidate()
    {
        foreach (StateEvent stateEvent in new List<StateEvent>(GetComponents<StateEvent>()))
        {
            if (stateEvent.gameEvent == null)
            {
                throw new UnityException("GameEvent not set : " + stateEvent.name);
            }
        }
    }
}
