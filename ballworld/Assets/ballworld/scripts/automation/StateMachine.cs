using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State state;    

    void Start()
    {
        state.onActivate.happen();
    }

    void Update()
    {
        foreach (Transition transition in state.transitions)
        {
            if (transition.condition.isMet())
            {
                state.onDeactivate.happen();
                state = transition.state;
                state.onActivate.happen();
                return;
            }
        }
        state.onActive.happen();
    }
}
