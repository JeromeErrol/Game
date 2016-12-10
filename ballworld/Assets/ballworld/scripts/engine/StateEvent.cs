using UnityEngine;

public class StateEvent : MonoBehaviour
{
    public EventEnum eventEnum;
    public ConditionalGameEvent gameEvent;

    void OnValidate()
    {
        if (gameEvent == null)
        {
            throw new UnityException("GameEvent not set : " + name);
        }
    }
}
