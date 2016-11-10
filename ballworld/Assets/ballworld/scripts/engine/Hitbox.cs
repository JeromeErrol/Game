using UnityEngine;

public class Hitbox : MonoBehaviour {

    public float power;
    public GameObject owner;

    void OnTriggerEnter(Collider collider)
    {
        Unit unit = collider.GetComponent<Unit>();

        if (unit != null)
        {
            Debug.Log("strike");
        }
    }
}
