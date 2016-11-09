using UnityEngine;

public class CircleObstacle : MonoBehaviour {

    public float force = 1f;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<Unit>() != null)
        {
            collider.transform.RotateAround(Vector3.zero, Vector3.Cross(collider.gameObject.transform.position, gameObject.transform.position), -force);
        }
    }
}
