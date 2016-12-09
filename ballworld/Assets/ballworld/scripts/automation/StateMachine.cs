using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State state;

    void Start()
    {
        if (state.onActivate != null)
        {
            state.onActivate.happen();
        }
    }

    void Update()
    {
        foreach (Transition transition in state.transitions)
        {
            if (transition.condition.isMet())
            {
                if(state.onDeactivate != null)
                {
                    state.onDeactivate.happen();
                }                
                state = transition.state;
                if (state.onActivate != null)
                {
                    state.onActivate.happen();
                }
                return;
            }
        }
        if (state.onActivate != null)
        {
            state.onActivate.happen();
        }
    }
}
