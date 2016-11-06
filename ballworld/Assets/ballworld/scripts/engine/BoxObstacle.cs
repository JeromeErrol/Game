using UnityEngine;
using System.Collections;

public class BoxObstacle : MonoBehaviour
{
    public float force = 1f;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<Unit>() != null)
        {
            Vector2 size = GetComponent<BallworldObject>().size;
            Vector3 left = (transform.right.normalized * (size.x / 2));
            Vector3 right = (transform.right.normalized * (-size.x / 2));
            Vector3 top = (transform.up.normalized * (size.y / 2));
            Vector3 topLeft = left + top;
            Vector3 topRight = top + right;
            Vector3 relative = collider.transform.position - transform.position;
            float dotA = Vector3.Dot(topLeft, relative);
            float dotB = Vector3.Dot(topRight, relative);
            bool a = dotA > 0;
            bool b = dotB > 0;

            if (a && b)
            {
                collider.transform.RotateAround(Vector3.zero, transform.right, -force);
            }
            else if (a && !b)
            {
                collider.transform.RotateAround(Vector3.zero, transform.up, force);
            }
            else if (!a && b)
            {
                collider.transform.RotateAround(Vector3.zero, transform.up, -force);
            }
            else
            {
                collider.transform.RotateAround(Vector3.zero, transform.right, force);
            }
        }
    }
}
