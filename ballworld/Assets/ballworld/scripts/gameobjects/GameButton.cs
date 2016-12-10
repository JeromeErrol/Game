using UnityEngine;

public class GameButton : MonoBehaviour
{
    public GameEvent onEnter;
    public GameEvent onStay;
    public GameEvent onExit;

    void OnTriggerEnter(Collider collider)
    {
        if (onEnter != null)
        {
            onEnter.happen();
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (onStay != null)
        {
            onStay.happen();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (onExit != null)
        {
            onExit.happen();
        }
    }
}
