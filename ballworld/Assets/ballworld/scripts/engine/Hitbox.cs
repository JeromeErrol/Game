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
            // direction of the force
            Vector3 difference = (unit.transform.position - owner.transform.position).normalized;
            unit.transform.position += (difference * power);
        }
    }
}
