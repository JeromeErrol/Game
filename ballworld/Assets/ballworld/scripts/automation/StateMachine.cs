using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State state;

    void Update()
    {      
        foreach (Transition transition in state.GetComponents<Transition>())
        {
            if (transition.condition.isMet())
            {
                state.process(EventEnum.ON_DEACTIVATED);
                state = transition.state;
                state.process(EventEnum.ON_ACTIVATED);
                return;
            }
        }
        state.process(EventEnum.ON_ATIVE);
    }    
}