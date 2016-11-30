using UnityEngine;

public class Boundary : MonoBehaviour
{
    public float force = 1f;

    private bool boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>() != null;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.GetComponent<Unit>() != null)
        {
            if (boxCollider)
            {
                boxCollision(collider.gameObject);
            }
            else
            {
                collider.transform.RotateAround(Vector3.zero, Vector3.Cross(collider.gameObject.transform.position, gameObject.transform.position), -force);
            }
        }
    }

    private void boxCollision(GameObject gameobject)
    {
            Vector2 size = GetComponent<BallworldObject>().size;
            Vector3 left = (transform.right.normalized * (size.x / 2));
            Vector3 right = (transform.right.normalized * (-size.x / 2));
            Vector3 top = (transform.up.normalized * (size.y / 2));
            Vector3 topLeft = left + top;
            Vector3 topRight = top + right;
            Vector3 relative = gameobject.transform.position - transform.position;
            float dotA = Vector3.Dot(topLeft, relative);
            float dotB = Vector3.Dot(topRight, relative);
            bool a = dotA > 0;
            bool b = dotB > 0;

            if (a && b)
            {
                gameobject.transform.RotateAround(Vector3.zero, transform.right, -force);
            }
            else if (a && !b)
            {
                gameobject.transform.RotateAround(Vector3.zero, transform.up, force);
            }
            else if (!a && b)
            {
                gameobject.transform.RotateAround(Vector3.zero, transform.up, -force);
            }
            else
            {
                gameobject.transform.RotateAround(Vector3.zero, transform.right, force);
            }
        }
}