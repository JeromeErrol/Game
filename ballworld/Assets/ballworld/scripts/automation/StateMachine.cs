using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State state;

    void Update()
    {
        foreach (Transition transition in state.transitions)
        {
            if (transition.condition.isMet())
            {
                state = transition.state;
                break;
            }
        }
    }
}
