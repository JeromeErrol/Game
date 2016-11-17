using UnityEngine;

public class Hazard : MonoBehaviour
{   


    void OnTriggerEnter(Collider collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit != null)
        {

        }
    }
}
