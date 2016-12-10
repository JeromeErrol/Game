using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State state;

    void Start()
    {
        state.process(EventEnum.ON_ACTIVATED);
    }

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
        state.process(EventEnum.ON_ACTIVE);
        UnityEditor.EditorGUIUtility.PingObject(state);
    }    
}