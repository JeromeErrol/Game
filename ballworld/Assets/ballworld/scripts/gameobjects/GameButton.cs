using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {

    public Gate gate;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null)
        {
            gate.open();
        }
    }
}
