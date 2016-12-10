using UnityEngine;
using System.Collections.Generic;

public class State : MonoBehaviour {

    public void process(EventEnum eventEnum)
    {
        foreach (StateEvent stateEvent in new List<StateEvent>(GetComponents<StateEvent>()))
        {
            if (stateEvent.eventEnum == eventEnum && (stateEvent.condition == null || stateEvent.condition.isMet()))
            {
                stateEvent.gameEvent.happen();
            }
        }
    }
}
