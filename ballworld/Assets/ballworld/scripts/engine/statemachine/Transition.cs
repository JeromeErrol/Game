using UnityEngine;

public class Transition : MonoBehaviour
{
    public Condition condition;
    public State state;

    void OnValidate()
    {
        if(state == null)
        {
            throw new UnityException("state is not set: " + name);
        }
        if (condition == null)
        {
            throw new UnityException("condition is not set: " + name);
        }
    }
}
