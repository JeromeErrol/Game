using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {

    public GameObject gate;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null)
        {
            gate.GetComponent<PlayMakerFSM>().SendEvent("open");
        }
    }
}
